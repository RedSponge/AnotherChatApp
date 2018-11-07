using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppClient.Net
{
    public class PacketMessageReceive : ReceivePacket
    {
        private string message;
        public PacketMessageReceive(byte[] data)
        {
            this.message = Constants.ENCODING.GetString(data);
        }

        public string GetMessage()
        {
            return message;
        }

        public override byte getId()
        {
            return 0x00000010;
        }
    }
}
