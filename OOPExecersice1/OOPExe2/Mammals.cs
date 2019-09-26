using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExe2
{
    public abstract class Mammals
    {
        private string _name;

        public Mammals(string name)
        {
            _name = name;
        }

        public void SayName()
        {
            Console.WriteLine("My name is :" + _name);
        }
        public abstract void Talk();
    }
}
