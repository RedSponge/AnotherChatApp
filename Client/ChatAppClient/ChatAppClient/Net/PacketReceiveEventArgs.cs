using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppClient.Net
{
    public class PacketReceiveEventArgs : EventArgs
    {
        public ReceivePacket packet { get; set; }

        public PacketReceiveEventArgs(ReceivePacket packet)
        {
            this.packet = packet;
        }
    }
}
