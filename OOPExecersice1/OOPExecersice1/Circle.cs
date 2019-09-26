using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExecersice1
{
    public class Circle : Figure
    {
        private int radious;
        public Circle(int r)
        {
            radious = r;
        }

        public int Radious
        {
            get
            {
                return radious;
            }
            set
            {
                Console.WriteLine("setting radio");
                radious = value;
            }

        }

        public override double GetArea()
        {
            return GetAreaSpecific();
        }

        private double GetAreaSpecific()
        {
            Console.WriteLine("getting area circle");
            return Math.PI * radious * radious;
        }
    }
}
