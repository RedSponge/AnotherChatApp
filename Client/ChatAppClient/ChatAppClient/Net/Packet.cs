using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppClient.Net
{
    public abstract class Packet
    {
        public abstract byte getCode();

        public abstract byte[] Data();
    }
}
