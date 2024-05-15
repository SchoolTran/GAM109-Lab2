using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserData userData = new UserData();
            Console.Write("Nhap Ten: ");
            userData.Name = Console.ReadLine();
            Console.WriteLine("UserData.Name: " +  userData.Name);

            Console.Write("Nhap ID: ");
            userData.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("UserData.ID: " + userData.ID);

            Console.Write("Nhap danh sach diem. Nhap so luong diem can nhap: ");
            int soLuongDiem = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < soLuongDiem; i++)
            {
                userData.Score.Add(Convert.ToDouble(Console.ReadLine()));
            }

            Console.Write("Danh sach diem vua nhap la: ");
            foreach (int i in userData.Score)
            {
                Console.Write(" " + i);
            }
            Console.ReadKey();
        }
    }
}
