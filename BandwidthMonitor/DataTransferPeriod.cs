using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BandwidthMonitor
{
    /// <summary>
    /// The amount of data transfer between two points in time
    /// </summary>
    class DataTransferPeriod
    {
        private long startTicks;
        private long endTicks;
        private long bytesIn;
        private long bytesOut;
        private long ticks { get { return endTicks - startTicks; } }

        public DataTransferPeriod(long newStartTicks, long newEndTicks, long newBytesIn, long newBytesOut)
        {
            startTicks = newStartTicks;
            endTicks = newEndTicks;
            bytesIn = newBytesIn;
            bytesOut = newBytesOut;
        }

        public long getStartTicks()
        {
            return startTicks;
        }

        public long getEndTicks()
        {
            return endTicks;
        }

        public long getBytesIn()
        {
            return bytesIn;
        }

        public long getBytesOut()
        {
            return bytesOut;
        }

        public double secondsInPeriod()
        {
            return (double)ticks / TimeSpan.TicksPerSecond;
        }

        public void print()
        {
            Console.WriteLine(secondsInPeriod() + " " + bytesIn + " " + bytesOut);
        }
    }
}
