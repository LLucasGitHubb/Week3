using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class client : Form
    {
        private Socket Client;

        public client()
        {
            InitializeComponent();
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            try
            {
                string message = tb_message.Text;
                byte[] data = Encoding.UTF8.GetBytes(message);
                if (Client != null)
                {
                    Client.SendTo(data, new IPEndPoint(IPAddress.Parse("255.255.255.255"), 8080));
                    lv_messageclient.Items.Add("Client: " + message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReceiveData()
        {
            Socket client = (Socket)Client;
            EndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                try
                {
                    byte[] data = new byte[1024];
                    int recv = client.ReceiveFrom(data, ref remoteEP);
                    string message = Encoding.UTF8.GetString(data, 0, recv);
                    string IP = ((IPEndPoint)remoteEP).Address.ToString();
                    int Port = ((IPEndPoint)remoteEP).Port;

                    if (InvokeRequired)
                    {
                        Invoke(new MethodInvoker(delegate
                        {
                            lv_messageclient.Items.Add("Server: " + message);
                        }));
                    }
                    else
                    {
                        lv_messageclient.Items.Add("Server: " + message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void client_Load(object sender, EventArgs e)
        {
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            Client.Bind(new IPEndPoint(IPAddress.Any, 8081));
            Thread receiveThread = new Thread(new ThreadStart(ReceiveData));
            receiveThread.Start();
        }
    }
}

