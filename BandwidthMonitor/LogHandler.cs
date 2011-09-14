using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BandwidthMonitor
{
    class LogHandler
    {
        private String logPath;

        public LogHandler(String newLogPath)
        {
            logPath = newLogPath;
        }

        /// <summary>
        /// Returns the file name of the log at this point in time
        /// </summary>
        /// <returns></returns>
        public String getCurrentLogFileName()
        {
            return TimeSpan.FromTicks(DateTime.UtcNow.Ticks).Days + "-" + DateTime.UtcNow.ToShortDateString().Replace('/', '-') + ".txt";
        }

        /// <summary>
        /// Returns the file name of the log which contains the most recent data before a specified point in time
        /// </summary>
        /// <param name="time">The number of ticks to the point in time</param>
        /// <returns>The name of the file</returns>
        private String getLogFileNameWithData(long time)
        {
            long dayToSelect = TimeSpan.FromTicks(time).Days;
            if (Directory.Exists(logPath))
            {
                try
                {
                    string[] fileNames = Directory.GetFiles(logPath);
                    fileNames = fileNames.Select(path => { return Path.GetFileName(path); }).ToArray();
                    var name = (from file in fileNames
                                let day = Convert.ToInt64(file.Split('-')[0])
                                where day <= dayToSelect
                                orderby day descending
                                select file).First();

                    return name;
                }
                catch (Exception e)
                {
                }
            }

            return getCurrentLogFileName();
        }

        /// <summary>
        /// Finds and returns the data transfer up to a given point in time
        /// </summary>
        /// <param name="comparisonTime">The number of ticks to the point in time</param>
        /// <returns>DataTransferInstant - the data transfer up to that point</returns>
        public DataTransferInstant getDataInstant(long comparisonTime)
        {
            long time = DateTime.UtcNow.Ticks;
            String name = getLogFileNameWithData(comparisonTime);

            if (File.Exists(Path.Combine(logPath, name)))
            {
                // http://msdn.microsoft.com/en-us/vcsharp/aa336746
                try
                {
                    var lastEntry = (from line in File.ReadLines(Path.Combine(logPath, name))
                                     let data = line.Split(',')
                                     let dataTime = Convert.ToInt64(data[0])
                                     orderby dataTime descending
                                     where dataTime < comparisonTime
                                     select new
                                     {
                                         Time = data[0],
                                         BytesIn = data[1],
                                         BytesOut = data[2]
                                     }).First();

                    return new DataTransferInstant(Convert.ToInt64(lastEntry.BytesIn), Convert.ToInt64(lastEntry.BytesOut));
                }
                catch (Exception e)
                {
                }

            }

            return new DataTransferInstant(0, 0);
        }

        /// <summary>
        /// Stores the specified instant data in a log file
        /// </summary>
        /// <param name="data"></param>
        public void Log(DataTransferInstant data)
        {
            String path = Path.Combine(logPath, getCurrentLogFileName());
            if (data.changed)
            {
                // ensure the path exists
                (new FileInfo(path)).Directory.Create();
                // log
                File.AppendAllText(path, data.ToCSV() + Environment.NewLine);
                data.changed = false;
            }
        }

        /// <summary>
        /// Returns the data for all days that there are log files for
        /// </summary>
        /// <returns></returns>
        public List<DataTransferPeriod> getDayData()
        {
            List<DataTransferPeriod> list = new List<DataTransferPeriod>();

            // loop through all the days with data
            if (Directory.Exists(logPath))
            {
                string[] fileNames = Directory.GetFiles(logPath);
                foreach (string name in fileNames)
                {
                    // find the start and end data for that day
                    string[] lines = File.ReadAllLines(name);
                    string[] start = lines[0].Split(',');
                    string[] end = lines[lines.Length - 1].Split(',');
                    long ticksStart = Convert.ToInt64(start[0]);
                    long ticksEnd = Convert.ToInt64(end[0]);

                    // work out the difference and store the value
                    long bytesIn = Convert.ToInt64(end[1]) - Convert.ToInt64(start[1]);
                    long bytesOut = Convert.ToInt64(end[2]) - Convert.ToInt64(start[2]);
                    list.Add(new DataTransferPeriod(ticksStart, ticksEnd, bytesIn, bytesOut, true));
                }
            }

            return list;
        }
        
    }
}
