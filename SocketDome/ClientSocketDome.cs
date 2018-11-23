using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketDome
{
    class ClientSocketDome : IScoket
    {
        private Socket client;
        private byte[] buffer;
        private NetworkStream netStream;
        private int id;

        /// <summary>
        /// 与客户端的交互
        /// </summary>
        /// <param name="socket">接受的客户端Socket对象</param>
        public ClientSocketDome(Socket client, int id)
        {
            this.id = id;
            this.client = client;
            this.buffer = new byte[2048];
            this.netStream = new NetworkStream(client);
        }

        public int ID => id;

        public event Action<int, Exception> OnError;

        public async void Start()
        {
            try
            {
                await this.netStream.ReadAsync(buffer, 0, buffer.Length);
            }
            catch (Exception e)
            {
                this.OnError?.Invoke(id, e);
            }
        }


    }
}
