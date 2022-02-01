using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SocketListner
{
    class Program
    {
        static void Main(string[] args)
        {
            Udp udp1 = new Udp();
            string groupEpAddress = "234.5.6.7";
            int groupEpPort = 59877;
            string message = "hello world";

            Dart.Sockets.IPEndPoint groupEp = new Dart.Sockets.IPEndPoint(groupEpAddress, groupEpPort);

            //Join Multicast group.
            udp1.Open(groupEp.Port);
            udp1.JoinMulticastGroup(groupEp.Address);

            //Send message.
            Console.WriteLine("Sending: {0}", message);
            udp1.Send(message, groupEp);

            //Receive response.
            byte[] buffer = new byte[1024];
            Datagram response = udp1.Receive(buffer);

            //Leave group.
            udp1.LeaveMulticastGroup(groupEp.Address);

            Console.WriteLine("Received: {0}", response.ToString());
            Console.WriteLine("Press <Enter> to exit.");
            Console.ReadLine();     
        }

    }
}
