using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketDome
{
    internal struct Buffers
    {
        private const int BUFFERSIZE = 2048;

        private byte[] buffer;
        private int curIndex;

        public byte[] Buffer => buffer;
        public int CurIndex => curIndex;
        public int RemainSize => buffer.Length - curIndex;
    }
}
