using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace Lab2_Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint serverEndpoint = new IPEndPoint(IPAddress.Any, 5000);

            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            serverSocket.Bind(serverEndpoint);
            serverSocket.Listen(10);

            Socket clientSocket = serverSocket.Accept();

            EndPoint clientEndpoint = clientSocket.RemoteEndPoint;
            Console.WriteLine("Client's infor: " + clientEndpoint.ToString());

            byte[] buff;
            string hello = "Hello client";
            buff = Encoding.ASCII.GetBytes(hello);

            clientSocket.Send(buff, 0, buff.Length, SocketFlags.None);

            Console.ReadKey();

            clientSocket.Close();
            serverSocket.Close();

        }
    }
}
