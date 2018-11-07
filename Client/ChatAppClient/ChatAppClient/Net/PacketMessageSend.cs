using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppClient.Net
{
    public class PacketMessageSend : SendPacket
    {
        private string data;

        public PacketMessageSend(string data)
        {
            this.data = data;
        }

        public override byte[] Data()
        {
            return Constants.ENCODING.GetBytes(data);
        }

        public override byte getId()
        {
            return 0x00000010;
        }
    }
}
