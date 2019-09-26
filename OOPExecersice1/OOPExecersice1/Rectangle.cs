using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExecersice1
{
    public class Rectangle : Figure
    {
        private int width;
        private int height;

        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }
        public override double GetArea()
        {
            Console.WriteLine("getting area rectangle");
            return width * height;
        }
    }
}
