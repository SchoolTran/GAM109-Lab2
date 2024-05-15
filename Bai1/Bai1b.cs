using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Bai1b
    {
        public static  void getDetail(dynamic value)
        {
            Console.WriteLine("value: " + value);
        }
        public static void bai1b()
        {
            getDetail(10);
            getDetail("gaemes");
            getDetail(true);
            getDetail(9.5);
        }
    }
}
