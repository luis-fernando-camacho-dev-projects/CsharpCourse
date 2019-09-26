using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("lazy");
            dog1.SayName();
            dog1.Talk();
        }
    }
}
