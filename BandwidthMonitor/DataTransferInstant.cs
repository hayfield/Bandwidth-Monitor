using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BandwidthMonitor
{
    /// <summary>
    /// The total amount of data transfer on a device up to a particular point in time
    /// </summary>
    class DataTransferInstant
    {
        /// <summary>
        /// The period of time at which the instant occurred (ticks)
        /// </summary>
        public long time { get; set; }
        /// <summary>
        /// The total number of bytes in at the instant
        /// </summary>
        public long bytesIn { get; set; }
        /// <summary>
        /// The total number of bytes out at the instant
        /// </summary>
        public long bytesOut { get; set; }
        /// <summary>
        /// Indicates whether the value has changed from the previous instant
        /// </summary>
        public bool changed;
        
        public DataTransferInstant(long newBytesIn, long newBytesOut)
        {
            changed = false;
            set(newBytesIn, newBytesOut);
        }

        /// <summary>
        /// Sets the bytes in and out values as the given parameters
        /// </summary>
        /// <param name="newBytesIn"></param>
        /// <param name="newBytesOut"></param>
        private void set(long newBytesIn, long newBytesOut)
        {
            if (bytesIn != newBytesIn || bytesOut != newBytesOut)
            {
                changed = true;
            }
            time = DateTime.Now.ToUniversalTime().Ticks;
            bytesIn = newBytesIn;
            bytesOut = newBytesOut;
        }

        /// <summary>
        /// Converts the time, bytesIn and bytesOut into a CSV format to store in a log file
        /// </summary>
        /// <returns>The CSV string</returns>
        public String ToCSV()
        {
            return time.ToString() + "," + bytesIn.ToString() + "," + bytesOut.ToString();
        }

        /// <summary>
        /// Adds additional bytes in and out to the current values
        /// </summary>
        /// <param name="additionalBytesIn"></param>
        /// <param name="additionalBytesOut"></param>
        public void Add(long additionalBytesIn, long additionalBytesOut)
        {
            set(bytesIn + additionalBytesIn, bytesOut + additionalBytesOut);
        }
    }
}
