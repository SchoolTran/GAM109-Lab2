using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        public static void bai2a()
        {
            var userInfp = new
            {
                id = "2024",
                name = "Faker",
                isplaing = false,
                bag = new
                {
                    skins = 0,
                    cup = 20,
                }
            };
            Console.WriteLine("\t id: " +userInfp.id);
            Console.WriteLine("\t name: " + userInfp.name);
            Console.WriteLine("\t isplaing: " + userInfp.isplaing);
            Console.WriteLine("\t bag skins: " + userInfp.bag.skins);
            Console.WriteLine("\t bag cup: " + userInfp.bag.cup);
        }

        public static void bai2b() 
        {
            int y = 10;
            Action<int> AnonymousMethod = delegate (int x)
            {
                int sum = x + y;
                int sub = x - y;
                Console.WriteLine("\t Sum: " + sum);
                Console.WriteLine("\t Sub: " + sub);
            };
            AnonymousMethod(5);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bai 2a ------------------------");
            bai2a();
            Console.WriteLine("Bai 2b ------------------------");
            bai2b();
            Console.ReadKey();

        }
    }
}
