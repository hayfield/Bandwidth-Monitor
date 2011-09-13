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
        /// The number of the second that is being tracked at present
        /// </summary>
        private byte second;
        /// <summary>
        /// The last 60 seconds worth of data transfer
        /// </summary>
        private DataTransferLump[] seconds = new DataTransferLump[60];

        public DataTransferTracker(long minutes, LogHandler logHandler)
        {
            if (minutes < 1)
            {
                throw new System.ArgumentOutOfRangeException("The number of minutes ago the track starts cannot be less than 1");
            }
            minutesIntoPast = minutes;

            // find the data transfer over the period
            startInstant = logHandler.getDataInstant(ticksAtStartPoint());
            DataTransferInstant currentInstant = logHandler.getDataInstant(DateTime.UtcNow.Ticks);
            bytesIn = currentInstant.bytesIn - startInstant.bytesIn;
            bytesOut = currentInstant.bytesOut - startInstant.bytesOut;

            // initialise the seconds
            second = 0;
            for (byte s = 0; s < 60; s++)
                seconds[s] = new DataTransferLump(0, 0);


        }

        public void updateSecond(DataTransferPeriod period, LogHandler logHandler)
        {
            if (second == 60)
            {
                second = 0;
                updateMinute();
            }
            bytesIn -= seconds[second].bytesIn;
            bytesOut -= seconds[second].bytesOut;
            seconds[second].set(period.getBytesIn(), period.getBytesOut());
            bytesIn += seconds[second].bytesIn;
            bytesOut += seconds[second].bytesOut;

            second++;
        }

        private void updateMinute()
        {

        }

        /// <summary>
        /// Finds the number of ticks at the point that the tracker started.
        /// Actually looks a minute after it started so it can be updated on a second-by-second basis.
        /// </summary>
        /// <returns></returns>
        private long ticksAtStartPoint()
        {
            return DateTime.UtcNow.Ticks - (minutesIntoPast - 1) * TimeSpan.TicksPerMinute;
        }
    }
}
