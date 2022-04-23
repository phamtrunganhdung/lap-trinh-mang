using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em1 = new Employee();
            string dataSubmit = "";

            Console.WriteLine("Nhap ID Nhan Vien");
            em1.EmployeeID = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Ho");
            em1.LastName = Console.ReadLine();
            Console.WriteLine("Nhap Ten");
            em1.FirstName = Console.ReadLine();
            Console.WriteLine("Nhap So Nam Lam Viec");
            em1.YearsService = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Luong Nhan Vien");
            em1.Salary = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Xac nhan gui thong tin...");
            Console.WriteLine("Bam phim bat ki de tiep tuc...");
            Console.WriteLine("Bam 'khong' de thoat");
            dataSubmit = Console.ReadLine();


            if (dataSubmit == "khong")
            {
                Console.WriteLine("khong the gui goi tin");
                return;
            }
            else
            {
                TcpClient client;
                try
                {
                    client = new TcpClient("127.0.0.1", 9050);
                }
                catch (SocketException)
                {
                    Console.WriteLine("Khong ket noi duoc voi server");
                    return;
                }

                NetworkStream ns = client.GetStream();
                byte[] data = em1.GetBytes();
                int size = em1.size;
                byte[] packsize = new byte[2];
                Console.WriteLine("Kich thuoc goi tin = {0}", size);
                packsize = BitConverter.GetBytes(size);
                ns.Write(packsize, 0, 2);
                ns.Write(data, 0, size);
                ns.Flush();

                ns.Close();
                client.Close();
            }

            
        }


       
    }
}
