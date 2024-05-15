using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class UserData
    {
        public int? ID;
        public string Name;
        public List<double> Score;

        public UserData()
        {
            ID = null;
            Name = null;
            Score = new List<double>();
        }
    }
}
