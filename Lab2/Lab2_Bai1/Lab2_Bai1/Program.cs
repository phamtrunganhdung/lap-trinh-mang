using System;
using System.Net;
using System.Net.Sockets;


namespace Lab2_Bai1
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
            Console.WriteLine(clientEndpoint.ToString());

            clientSocket.Close();
            serverSocket.Close();
        }
    }
}
