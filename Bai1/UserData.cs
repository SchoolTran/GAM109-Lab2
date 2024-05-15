using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class UserData
    {
        public int ID;
        public string Name;
        public int Level;

        public UserData()
        {
            ID = 0;
            Name = null;
            Level = 0;
        }

        public UserData(int id, string name, int level)
        {
            ID = id;
            Name = name;
            Level = level;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Lever: " + Level);
        }


    }
}
