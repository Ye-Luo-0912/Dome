using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketDome
{
    interface IScoket
    {
        void Start();

        int ID { get; }

        event Action<int,Exception> OnError;
    }
}
