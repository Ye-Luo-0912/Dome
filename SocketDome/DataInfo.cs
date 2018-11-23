using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketDome
{
    public struct DataInfo
    {
        public bool IsSuccess { get; set; }

        public object Data { get; set; }

        public string Message { get; set; }

        public RequestCode Request { get; set; }
    }

    public enum RequestCode
    {
        Message,
    }
}
