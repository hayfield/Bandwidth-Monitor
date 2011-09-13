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
        List<NetInterface> interfaces = new List<NetInterface>();

        /// <summary>
        /// The network interfaces that have an operational status that isn't 'Up'
        /// </summary>
        List<NetInterface> notUpInterfaces = new List<NetInterface>();

        public NetInterfaces()
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                NetInterface netInterface = new NetInterface(adapter);
                if (adapter.OperationalStatus == OperationalStatus.Up)
                    interfaces.Add(netInterface);
                else
                    notUpInterfaces.Add(netInterface);
            }
        }

        public void update()
        {
            foreach (NetInterface adapter in interfaces.Concat(notUpInterfaces))
            {
                adapter.update();
            }
        }
    }
}
