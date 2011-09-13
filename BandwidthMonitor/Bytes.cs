using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BandwidthMonitor
{
    static class Bytes
    {
        public static double ToKilobytes(long bytes)
        {
            return (double)bytes / 1024;
        }

        public static double ToMegabytes(long bytes)
        {
            return (double)bytes / 1048576;
        }

        public static double ToGigabytes(long bytes)
        {
            return (double)bytes / 1073741824;
        }

        public static double ToTerabytes(long bytes)
        {
            return (double)bytes / 1099511627776;
        }

        public static double ToPetabytes(long bytes)
        {
            return (double)bytes / 1125899906842624;
        }
    }
}
