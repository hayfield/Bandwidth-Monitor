using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BandwidthMonitor
{
    /// <summary>
    /// Tracks the data transfer between a specified number of minutess in the past and the present
    /// </summary>
    class DataTransferTracker
    {
        #region variables

        /// <summary>
        /// The number of minutes into the past being tracked
        /// </summary>
        private long minutesIntoPast;
        /// <summary>
        /// The number of bytes in over the given period
        /// </summary>
        private long bytesIn;
        /// <summary>
        /// The number of bytes out over the given period
        /// </summary>
        private long bytesOut;
        /// <summary>
        /// The instant that the tracker starts
        /// </summary>
        private DataTransferInstant startInstant;
        /// <summary>
        /// A minute after the instant that the tracker starts
        /// </summary>
        private DataTransferInstant minuteAfterStartInstant;
        /// <summary>
        /// The number of bytes to remove each second
        /// </summary>
        private DataTransferLump bytesStartPerSecond = new DataTransferLump(0, 0);
        /// <summary>
        /// The number of additional bytes to remove each minute
        /// </summary>
        private DataTransferLump bytesStartLeftover = new DataTransferLump(0, 0);
        /// <summary>
        /// The number of the second that is being tracked at present
        /// </summary>
        private byte second;
        /// <summary>
        /// The last 60 seconds worth of data transfer
        /// </summary>
        private DataTransferLump[] seconds = new DataTransferLump[60];

        #endregion variables

        public DataTransferTracker(long minutes, LogHandler logHandler)
        {
            if (minutes < 1)
            {
                throw new System.ArgumentOutOfRangeException("The number of minutes ago the track starts cannot be less than 1");
            }
            minutesIntoPast = minutes;

            // find the data transfer over the period
            setStartInstantValues(logHandler);
            DataTransferInstant currentInstant = logHandler.getDataInstant(DateTime.UtcNow.Ticks);
            bytesIn = currentInstant.bytesIn - startInstant.bytesIn;
            bytesOut = currentInstant.bytesOut - startInstant.bytesOut;

            // initialise the seconds
            second = 0;
            for (byte s = 0; s < 60; s++)
                seconds[s] = new DataTransferLump(0, 0);
        }

        /// <summary>
        /// Loads the values regarding the start instant for the tracker
        /// </summary>
        /// <param name="logHandler"></param>
        private void setStartInstantValues(LogHandler logHandler)
        {
            startInstant = logHandler.getDataInstant(ticksAtStartPoint());
            // try looking slightly after a minute ahead to account for any delays in saving
            minuteAfterStartInstant = logHandler.getDataInstant(ticksAtStartPoint() + (long)(TimeSpan.TicksPerMinute * 1.02));

            // work out how many bytes change should be made each second so there's no sudden jump when the minute changes
            long inDiff = minuteAfterStartInstant.bytesIn - startInstant.bytesIn;
            long outDiff = minuteAfterStartInstant.bytesOut - startInstant.bytesOut;
            bytesStartPerSecond.bytesIn = inDiff / 60;
            bytesStartPerSecond.bytesOut = outDiff / 60;

            bytesStartLeftover.bytesIn = inDiff - bytesStartPerSecond.bytesIn * 60;
            bytesStartLeftover.bytesOut = outDiff - bytesStartPerSecond.bytesOut * 60;
        }

        /// <summary>
        /// Update the tracker every second
        /// </summary>
        /// <param name="period"></param>
        /// <param name="logHandler"></param>
        public void updateSecond(DataTransferPeriod period, LogHandler logHandler)
        {
            if (second == 60)
            {
                second = 0;
                updateMinute(logHandler);
            }
            bytesIn -= bytesStartPerSecond.bytesIn;
            bytesOut -= bytesStartPerSecond.bytesOut;
            seconds[second].set(period.getBytesIn(), period.getBytesOut());
            bytesIn += seconds[second].bytesIn;
            bytesOut += seconds[second].bytesOut;

            second++;
        }

        /// <summary>
        /// Make some additional changes to the tracker every minute
        /// </summary>
        private void updateMinute(LogHandler logHandler)
        {
            // remove any leftover bytes
            bytesIn -= bytesStartLeftover.bytesIn;
            bytesOut -= bytesStartLeftover.bytesOut;
            // update the start point
            setStartInstantValues(logHandler);
        }

        /// <summary>
        /// Finds the number of ticks at the point that the tracker started.
        /// </summary>
        /// <returns></returns>
        private long ticksAtStartPoint()
        {
            return DateTime.UtcNow.Ticks - minutesIntoPast * TimeSpan.TicksPerMinute;
        }

        /// <summary>
        /// Prints an output to console
        /// </summary>
        public void print()
        {
            Console.WriteLine("In: " + bytesIn + " Out: " + bytesOut);
        }
    }
}
