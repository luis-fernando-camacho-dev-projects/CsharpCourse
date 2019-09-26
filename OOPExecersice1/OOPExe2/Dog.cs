using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExe2
{
    public class Dog : Mammals
    {
        public Dog(string name) : base(name)
        {
        }

        public override void Talk()
        {
            Console.WriteLine("Bark Bark");
        }
    }
}
