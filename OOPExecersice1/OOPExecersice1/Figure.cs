using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExecersice1
{
    public abstract class Figure
    {
        public abstract double GetArea();

        public void PrintFigure()
        {
            Console.WriteLine("Get Area" + GetArea());
        }
    }
}
