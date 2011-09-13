using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;

namespace BandwidthMonitor
{
    class NetInterfaces
    {
        /// <summary>
        /// The active Network Interfaces
        /// </summary>
        public List<NetInterface> interfaces = new List<NetInterface>();

        public NetInterfaces()
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                NetInterface netInterface = new NetInterface(adapter);
                interfaces.Add(netInterface);
            }
        }

        public void update()
        {
            foreach (NetInterface adapter in interfaces)
            {
                adapter.update();
            }
        }

    }
}
