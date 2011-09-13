using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BandwidthMonitor
{
    static class Bytes
    {
        public static double ToKb(long bytes)
        {
            return (double)bytes / 1024;
        }

        public static double ToMb(long bytes)
        {
            return (double)bytes / 1048576;
        }

        public static double ToGb(long bytes)
        {
            return (double)bytes / 1073741824;
        }

        public static double ToTb(long bytes)
        {
            return (double)bytes / 1099511627776;
        }

        public static double ToPb(long bytes)
        {
            return (double)bytes / 1125899906842624;
        }
    }
}
