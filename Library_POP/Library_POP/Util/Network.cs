using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Library_POP.Util
{
    internal class Network
    {
        public static string getLocalIP(NetworkInterfaceType _type) {

            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }

            return output;
        }

        public static string getAutomaticLocalIP()
        {
            string output = getLocalIP(NetworkInterfaceType.Wireless80211);

            if ( output.Length == 0)
            {
                output = getLocalIP(NetworkInterfaceType.Ethernet);
            }

            return output;

        }

    }
}
