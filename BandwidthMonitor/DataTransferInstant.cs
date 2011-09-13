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
        public long time { get; set; }
        public long bytesIn { get; set; }
        public long bytesOut { get; set; }
        public bool changed;
        
        public DataTransferInstant(long newBytesIn, long newBytesOut)
        {
            changed = false;
            set(newBytesIn, newBytesOut);
        }

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

        public String ToCSV()
        {
            return time.ToString() + "," + bytesIn.ToString() + "," + bytesOut.ToString();
        }

        public void Add(long additionalBytesIn, long additionalBytesOut)
        {
            set(bytesIn + additionalBytesIn, bytesOut + additionalBytesOut);
        }
    }
}
