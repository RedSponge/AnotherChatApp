using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace ChatAppClient.Net
{
    public class SocketHandler
    {
        private StreamReader In;
        private StreamWriter Out;
        private TcpClient client;

        private Thread thread;
        private bool listening;

        public event HandlePacket PacketReceiveEvent;

        public void Connect(string ip, int port)
        {
            client = new TcpClient(ip, port);
            In = new StreamReader(client.GetStream(), Constants.ENCODING);
            Out = new StreamWriter(client.GetStream(), Constants.ENCODING);

            thread = new Thread(HandleRead);
            listening = true;
            thread.Start();
        }

        private void HandleRead()
        {
            while (listening)
            {
                string inn = In.ReadLine();
                if (inn.EndsWith("\n")) inn = inn.Substring(0, inn.Length - 1);

                byte[] data = Constants.ENCODING.GetBytes(inn);
                byte header = data[0];

                bool send = (header >> 7 == 1);
                if (!send)
                {
                    byte id = (byte)(header & 0x0111111);
                    byte[] restOfData = new byte[data.Length - 1];

                    for (int i = 1; i < data.Length; i++)
                    {
                        restOfData[i - 1] = data[i];
                    }

                    switch (id)
                    {
                        case 0x00000001:
                            MessageBox.Show("Ping Recieved!");
                            break;
                        case 0x00000010:
                            PacketReceiveEvent.Invoke(this, new PacketReceiveEventArgs(new PacketMessageReceive(restOfData)));
                            break;
                    }
                }
            }
        }

        public void SendPacket(SendPacket packet)
        {
            Out.Write(packet.GetSentData());
            Out.Write('\n');
            Out.Flush();
        }

        public void Disconnect()
        {
            listening = false;
            thread.Join();
            In.Close();
            Out.Close();
            client.Close();
        }

        public delegate void HandlePacket(object sender, PacketReceiveEventArgs args);
    }
}
