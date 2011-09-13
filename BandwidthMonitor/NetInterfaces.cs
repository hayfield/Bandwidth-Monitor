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
            interfaces = interfaces.OrderBy(adapter => adapter.name).ToList();
            if (!Properties.Settings.Default.TrackedAdapterSet)
            {
                Properties.Settings.Default.TrackedAdapter = interfaces[0].ID;
            }
        }

        public static int InterfaceIndexWithID(String ID)
        {
            int i = 0;
            foreach (NetInterface adapter in interfaces)
            {
                if (adapter.ID == ID)
                {
                    return i;
                }
                i++;
            }
            return 0;
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
