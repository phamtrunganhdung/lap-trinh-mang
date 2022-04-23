using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace Lab2_bai3_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint serverEndpoint = new IPEndPoint(IPAddress.Loopback, 5000);

            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Console.WriteLine("Dang ket noi voi server....");

            try
            {
                serverSocket.Connect(serverEndpoint);
                if (serverSocket.Connected)
                {
                    Console.WriteLine("Ket noi thanh cong voi server...");
                    byte[] buff = new byte[32];
                    int byteReceive = serverSocket.Receive(buff, 0, buff.Length, SocketFlags.None);
                    string message = Encoding.ASCII.GetString(buff, 0, byteReceive);
                    Console.WriteLine("Thong diep tu server: " + message);
                }
            }
            catch
            {
                Console.WriteLine("Khong the ket noi den server");
                return;
            }
           

            Console.ReadKey();
            serverSocket.Close();
        }
    }
}
