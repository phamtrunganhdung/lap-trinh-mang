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

namespace Server
{
    public partial class ServerForm : Form
    {
        private IPAddress serverIP;
        public IPAddress ServerIP
        {
            get
            {
                return serverIP;
            }
            set
            {
                this.serverIP = value;
            }
        }
        private int port;
        public int Port
        {
            get
            {
                return this.port;
            }
            set
            {
                this.port = value;
            }
        }
        Socket serverSocket = null;
        IPEndPoint serverEP = null;
        Socket clientSocket = null;
        byte[] buff = new byte[1024];
        int byteReceive = 0;
        string stringReceive = "";
        public ServerForm(IPAddress ServerIP, int Port)
        {
            this.ServerIP = ServerIP;
            this.Port = Port;
        }

        public ServerForm()
        {
            InitializeComponent();
        }
        public void Listen()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
            serverEP = new IPEndPoint(IPAddress.Any, 9001);
            serverSocket.Bind(serverEP);
            serverSocket.Listen(5);
            UpdateStatus("Đang chờ kết nối ...");
            serverSocket.BeginAccept(new AsyncCallback(AcceptScoket),
           serverSocket);
        }
        private void AcceptScoket(IAsyncResult ia)
        {
            Socket s = (Socket)ia.AsyncState;
             clientSocket = s.EndAccept(ia);
            string hello = "Hello Client";
            buff = Encoding.ASCII.GetBytes(hello);
            UpdateStatus("Client " + clientSocket.RemoteEndPoint.ToString()
            + " đã kết nối đến");
            clientSocket.BeginSend(buff, 0, buff.Length, SocketFlags.None, new
            AsyncCallback(SendData), clientSocket);
        }
        private void SendData(IAsyncResult ia)
        {
            Socket s = (Socket)ia.AsyncState;
            s.EndSend(ia);
            buff = new byte[1024];
            s.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new
           AsyncCallback(ReceiveData), s);
        }

        private void ReceiveData(IAsyncResult ia)
        {
            Socket s = (Socket)ia.AsyncState;
            try
            {
                 byteReceive = s.EndReceive(ia);
            }
            catch
            {
                this.Close();
                UpdateStatus("Client ngắt kết nối");
                this.Listen();
                return;
            }
            if (byteReceive == 0)
            {
                Close();
                UpdateStatus("Client đóng kết nối");
            }
            else
            {
                stringReceive = Encoding.ASCII.GetString(buff, 0, byteReceive);
                lbText.Items.Add(stringReceive);
            s.BeginSend(buff, 0, buff.Length, SocketFlags.None, new
AsyncCallback(SendData), s);
            }
        }

        public void CloseServer()
        {
            clientSocket.Close();
            serverSocket.Close();
        }


        public void UpdateStatus(string status)
        {
            txtStatus.Text = status;
        }
        private void ServerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            Listen();
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            CloseServer();
        }
    }
}
