using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {
        byte[] buff = new byte[1024];
        int byteReceive = 0;
        string stringReceive ="";
        Socket serverSocket = new Socket(AddressFamily.InterNetwork,
       SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint serverEP = null;
        public ClientForm()
        {
            InitializeComponent();
        }

        public void UpdateStatus(string status)
        {
            txtStatus.Text = status;
        }
        public void ClearInput()
        {
            txtInput.Text = "";
        }
        public void ConnectToServer(IPAddress serverIP, int Port)
        {
            serverEP = new IPEndPoint(serverIP, Port);
 serverSocket.BeginConnect(serverEP, new
AsyncCallback(ConnectCallback), serverSocket);
        }
        private void ConnectCallback(IAsyncResult ia)
        {
            Socket s = (Socket)ia.AsyncState;
            try
            {
                UpdateStatus("Đang chờ kết nối");
                s.EndConnect(ia);
                UpdateStatus("Kết nối thành công");
            }
            catch
            {
                UpdateStatus("Kết nối thất bại");
                return;
            }
            s.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new
           AsyncCallback(ReceiveData), s);
        }

        private void ReceiveData(IAsyncResult ia)
        {
            Socket s = (Socket)ia.AsyncState;
            byteReceive = s.EndReceive(ia);
            stringReceive = Encoding.ASCII.GetString(buff, 0, byteReceive);
            lbText.Items.Add(stringReceive);
        }

        private void SendData(IAsyncResult ia)
        {
            Socket s = (Socket)ia.AsyncState;
            s.EndSend(ia);
            buff = new byte[1024];
            s.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new
            AsyncCallback(ReceiveData), s);
        }

        public bool Disconnect()
        {
            try
            {
                serverSocket.Shutdown(SocketShutdown.Both);
                serverSocket.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void SendData(string Data)
        {
            buff = Encoding.ASCII.GetBytes(Data);
            serverSocket.BeginSend(buff, 0, buff.Length, SocketFlags.None, new
            AsyncCallback(SendToServer), serverSocket);
        }

        private void SendToServer(IAsyncResult ia)
        {
            Socket s = (Socket)ia.AsyncState;
            s.EndSend(ia);
            buff = new byte[1024];
            s.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new
            AsyncCallback(ReceiveData), s);
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
           ConnectToServer(IPAddress.Parse("127.0.0.1"), 9001);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendData(txtInput.Text);
            ClearInput();
        }
    }
}
