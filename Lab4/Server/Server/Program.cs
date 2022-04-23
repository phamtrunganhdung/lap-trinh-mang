using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.IO;
using System.Text;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[1024];
            TcpListener server = new TcpListener(IPAddress.Any, 9050);
            server.Start();
            TcpClient client = server.AcceptTcpClient();
            NetworkStream ns = client.GetStream();

            byte[] size = new byte[2];
            int recv = ns.Read(size, 0, 2);
            int packsize = BitConverter.ToUInt16(size, 0);
            Console.WriteLine("kich thuoc goi tin = {0}", packsize);
            recv = ns.Read(data, 0, packsize);
            Employee em1 = new Employee(data);
            Console.WriteLine("ID Nhan Vien = {0}", em1.EmployeeID);
            Console.WriteLine("Ho = {0}", em1.LastName);
            Console.WriteLine("Ten = {0}", em1.FirstName);
            Console.WriteLine("So Nam Lam Viec = {0}", em1.YearsService);
            Console.WriteLine("Luong = {0} VND\n", em1.Salary);
            string[] nhanVien = { em1.EmployeeID.ToString(), em1.LastName, em1.FirstName, em1.YearsService.ToString(), em1.Salary.ToString() };
            File.WriteAllLines("E:\\TaiLieu\\lap-trinh-mang-dlu\\Lab4\\Server\\Server\\file\\nhanvien.txt", nhanVien);
            Console.WriteLine("Luu vao file thanh cong");

            ns.Close();
            client.Close();
            server.Stop();
        }
    }
}