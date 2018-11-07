using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppClient.Net
{
    public abstract class ReceivePacket : Packet
    {
        public override byte getCode()
        {
            return (byte)(0x01111111 & getId());
        }

        public abstract byte getId();

        public override byte[] Data()
        {
            throw new Exception("Data call on recieve packet!");
        }
    }
}
