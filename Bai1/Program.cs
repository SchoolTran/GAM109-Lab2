using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai1 a");
            Bai1a.Start();

            Console.WriteLine();

            Console.WriteLine("Bai1 b");
            Bai1b.bai1b();

            Console.WriteLine();

            Console.WriteLine("Bai1c");
            var bai1c = new UserData(11351, "Tran Nguyen Hai Truong", 20);
            bai1c.DisplayInfo();

            Console.ReadKey();
        }
    }
}
