using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BandwidthMonitor
{
    class Tracker : Dictionary<String, DataTransferTracker>
    {
        public Tracker(long minutes, LogHandler logHandler)
        {

        }
    }
}
