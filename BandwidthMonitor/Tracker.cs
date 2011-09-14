using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BandwidthMonitor
{
    class Tracker : Dictionary<String, DataTransferTracker>
    {
        public Tracker(LogHandler logHandler)
        {
            this.Add("Minute", new DataTransferTracker(1, logHandler));
            this.Add("Hour", new DataTransferTracker(60, logHandler));

        }

        public void Update(DataTransferPeriod period, LogHandler logHandler)
        {
            foreach (var entry in this)
            {
                entry.Value.updateSecond(period, logHandler);
            }
        }
    }
}
