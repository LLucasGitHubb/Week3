using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Week3
{
    public partial class server : Form
    {
        UdpClient serverr;
        Thread receiveThread;

        public server()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serverr = new UdpClient(8080);
            receiveThread = new Thread(new ThreadStart(ReceiveData));
            receiveThread.Start();
        }

        private void ReceiveData()
        {
            while (true)
            {
                try
                {
                    IPEndPoint clientEP = new IPEndPoint(IPAddress.Any, 0);
                    byte[] data = serverr.Receive(ref clientEP);
                    string message = Encoding.UTF8.GetString(data);
                    string IP = clientEP.Address.ToString();
                    int Port = clientEP.Port;
                    if (InvokeRequired)
                    {
                        Invoke(new MethodInvoker(delegate
                        {
                            lv_message.Items.Add("Client : " + message);
                        }));
                    }
                    else
                    {
                        lv_message.Items.Add("Client : " + message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddMessage(string message)
        {
            if (lv_message.InvokeRequired)
            {
                lv_message.Invoke(new Action<string>(AddMessage), message);
                return;
            }
            lv_message.Items.Add(message);
            lv_message.EnsureVisible(lv_message.Items.Count - 1);
            lv_message.Columns[0].Width = -1;
        }

        private void bt_send_Click_1(object sender, EventArgs e)
        {
            string message = tb_message.Text;
            byte[] data = Encoding.UTF8.GetBytes(message);
            serverr.Send(data, data.Length, "127.0.0.1", 8081);
            lv_message.Items.Add("Server: " + message);
        }
    }
}
