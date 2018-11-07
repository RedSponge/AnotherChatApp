using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppClient.Net
{
    public abstract class SendPacket : Packet
    {
        public override byte getCode()
        {
            return (byte)(0x10000000 | getId()); 
        }

        public abstract byte getId();

        public byte[] GetSentData()
        {
            byte[] data = Data();
            byte[] o = new byte[data.Length+1];
            o[0] = getCode();
            for(int i = 0; i < data.Length; i++)
            {
                o[i + 1] = data[i];
            }
            return o;
        }

    }
}
