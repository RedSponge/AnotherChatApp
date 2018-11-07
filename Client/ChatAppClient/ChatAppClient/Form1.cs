using ChatAppClient.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAppClient
{
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }

        private SocketHandler connection;
        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SocketHandler();
            connection.Connect("localhost", 12345);

            connection.PacketReceiveEvent += HandlePacket;
        }

        private void HandlePacket(object sender, PacketReceiveEventArgs args)
        {
            MessageBox.Show("PACKET!");
            if(args.packet is PacketMessageReceive)
            {
                MessageBox.Show(((PacketMessageReceive)args.packet).GetMessage());
            }
        }
    }
}
