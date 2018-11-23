using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketDome
{
    class Server
    {
        private static List<IScoket> clientList = new List<IScoket>();

        private static async void Start()
        {
            var iP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5555);
            var serverSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);

            serverSocket.Bind(iP);

            try
            {
                Socket cSocket = await serverSocket.AcceptAsync();
                IScoket client = new ClientSocketDome(cSocket);

                client.Start();
                clientList.Add(client);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
