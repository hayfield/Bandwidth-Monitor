using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;

namespace BandwidthMonitor
{
    static class NetInterfaces
    {
        /// <summary>
        /// The active Network Interfaces
        /// </summary>
        public static List<NetInterface> interfaces = new List<NetInterface>();

        static NetInterfaces()
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                NetInterface netInterface = new NetInterface(adapter);
                interfaces.Add(netInterface);
            }
        }

        public static void update()
        {
            foreach (NetInterface adapter in interfaces)
            {
                adapter.update();
                if (adapter.ID == Properties.Settings.Default.TrackedAdapter)
                {
                    adapter.OutputValues();
                }
            }
        }

    }
}
