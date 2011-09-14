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
            this.Add("Day", new DataTransferTracker(1440, logHandler));
            this.Add("Week", new DataTransferTracker(10080, logHandler));
            this.Add("Month", new DataTransferTracker(43200, logHandler));
            this.Add("Year", new DataTransferTracker(525600, logHandler));
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
