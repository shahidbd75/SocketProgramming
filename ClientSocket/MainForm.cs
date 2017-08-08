using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ClientSocket
{
    public partial class MainForm : Form
    {
        TcpClient client = new TcpClient();
        public MainForm()
        {

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblHeader.Text = "From Client program: Server Connected....";
            client.Connect(IPAddress.Loopback,8888);
            txtServerMsg.Text += "\n>> Client Started";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            NetworkStream stream=client.GetStream();

            // Send Data
            byte[] sendDataBytes = Encoding.ASCII.GetBytes(txtClientMessage.Text.Trim() + "$");
            stream.Write(sendDataBytes,0,sendDataBytes.Length);
            stream.Flush();

            //Receive Data

            byte[] receiveDataBytes = new byte[1024*1024];
            stream.Read(receiveDataBytes, 0, client.ReceiveBufferSize);
            txtClientMessage.Text += Encoding.ASCII.GetString(receiveDataBytes);
            stream.Flush();

            txtClientMessage.Text = string.Empty;
            txtClientMessage.Focus();

            txtServerMsg.Text += "\n>> " + Encoding.ASCII.GetString(receiveDataBytes);
        }
    }
}
