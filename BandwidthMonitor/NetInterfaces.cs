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
                if (Properties.Settings.Default.TrackedAdapter.Length > 0)
                {
                    Properties.Settings.Default.TrackedAdapterSet = true;
                }
                else
                {
                    Properties.Settings.Default.TrackedAdapter = interfaces[0].ID;
                }
            }
        }

        /// <summary>
        /// Returns the interface being tracked
        /// </summary>
        /// <returns></returns>
        public static NetInterface TrackedInterface()
        {
            return interfaces[InterfaceIndexWithID(Properties.Settings.Default.TrackedAdapter)];
        }

        /// <summary>
        /// Finds the ID of the interface being tracked within the list
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Update the interfaces
        /// </summary>
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
