﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.IO;
using System.Data;

namespace BandwidthMonitor
{
    class NetInterface
    {
        #region variables

        /// <summary>
        /// The network adapter to watch
        /// </summary>
        NetworkInterface adapter;
        /// <summary>
        /// The network adapter properties
        /// </summary>
        IPInterfaceProperties properties;
        /// <summary>
        /// The network adapter stats
        /// </summary>
        IPv4InterfaceStatistics stats;

        /// <summary>
        /// The data transfer between a timer event being fired twice, causing it to update
        /// </summary>
        public DataTransferPeriod period;

        /// <summary>
        /// The data transfer up to the current point in time
        /// </summary>
        DataTransferInstant dataInstant;
        /// <summary>
        /// Something to handle logging
        /// </summary>
        LogHandler logHandler;

        /// <summary>
        /// The time the data transfer period started
        /// </summary>
        private long dataTransferStart;
        /// <summary>
        /// The number of bytes in since the adapter stats reset
        /// </summary>
        private long bytesInSession;
        /// <summary>
        /// The number of bytes out since the adapter stats reset
        /// </summary>
        private long bytesOutSession;

        /// <summary>
        /// The directory path to the location to store log files for this adapter
        /// </summary>
        String logPath;

        /// <summary>
        /// The name of the interface
        /// </summary>
        public String name
        {
            get
            {
                if (adapter.OperationalStatus == OperationalStatus.Up)
                    return "[UP] " + adapter.Description;
                else
                    return adapter.Description;
            }
        }
        /// <summary>
        /// The ID of the interface
        /// </summary>
        public String ID { get { return adapter.Id; } }

        /// <summary>
        /// Contains various trackers for the adapter
        /// </summary>
        public Tracker Tracker;

        #endregion variables

        public NetInterface(NetworkInterface adapterIn)
        {
            // set up the adapter
            adapter = adapterIn;
            stats = adapter.GetIPv4Statistics();

            // set up the logging
            logPath = Path.Combine("logs", Path.Combine(adapter.Description, adapter.GetPhysicalAddress().ToString(), adapter.Id));
            logHandler = new LogHandler(logPath);
            loadDataInstant(DateTime.UtcNow.Ticks);
            
            // set up the data tracking
            dataTransferStart = currentTicks();
            bytesInSession = stats.BytesReceived;
            bytesOutSession = stats.BytesSent;
            properties = adapter.GetIPProperties();
            Console.WriteLine(adapter.Name + " " + adapter.Description + " " + adapter.OperationalStatus);

            Tracker = new Tracker(logHandler);

            readFile();
        }

        private long bytesIn()
        {
            stats = adapter.GetIPv4Statistics();
            long bytesIn = stats.BytesReceived;
            long bytesRecent = bytesIn - bytesInSession;
            bytesInSession = bytesIn;

            return bytesRecent;
        }

        private long bytesOut()
        {
            stats = adapter.GetIPv4Statistics();
            long bytesOut = stats.BytesSent;
            long bytesRecent = bytesOut - bytesOutSession;
            bytesOutSession = bytesOut;

            return bytesRecent;
        }

        private long updateDataTransferStart()
        {
            dataTransferStart = currentTicks();
            return dataTransferStart;
        }

        private long currentTicks()
        {
            return DateTime.Now.ToUniversalTime().Ticks;
        }

        public void update()
        {
            period = new DataTransferPeriod(dataTransferStart, updateDataTransferStart(), bytesIn(), bytesOut());
            updateDataInstant();
            Tracker.Update(period, logHandler);
        }

        private void updateDataInstant()
        {
            dataInstant.Add(period.getBytesIn(), period.getBytesOut());
            updateLog(dataInstant);
        }

        private void loadDataInstant(long time)
        {
            dataInstant = logHandler.getDataInstant(time);
        }

        private void updateLog(DataTransferInstant data)
        {
            logHandler.Log(data);
        }

        private void readFile()
        {
            Console.WriteLine(adapter.Id + " " + adapter.GetPhysicalAddress());
            Console.WriteLine(logPath);
            // http://stackoverflow.com/questions/2955402/how-do-i-create-directory-if-doesnt-exist-to-create-file
            //(new FileInfo(logPath)).Directory.Create();
            // File.WriteAllText(logPath, "green pie");
        }

        public override String ToString()
        {
            return name;
        }

        public void OutputValues()
        {
            Console.WriteLine(adapter.Description);
            //MinuteTracker.print();
        }
    }
}
