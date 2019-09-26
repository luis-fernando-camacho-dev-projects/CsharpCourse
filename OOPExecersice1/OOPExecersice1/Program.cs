using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExecersice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure circle1 = new Circle(10);
            Figure rectangle1 = new Rectangle(15, 13);

            //Console.WriteLine(circle1.Radious);
            //circle1.Radious = 12;

            Figure[] figures = new Figure[2];
            figures[0] = circle1;
            figures[1] = rectangle1;
            Program c = new Program();
            c.PrintAreas(figures);
            //PrintAreasStatic(figures);
        }

        public void PrintAreas(Figure[] figures)
        {
            foreach (Figure f in figures)
            {
                f.PrintFigure();
                //Console.WriteLine(f.GetArea());
            }
            
        }

        public static void PrintAreasStatic(Figure[] figures)
        {
            foreach (Figure f in figures)
            {
                Console.WriteLine(f.GetArea());
            }
            //for (int i = 0; i < figures.Length; i++)
            //{
            //    Console.WriteLine(f.GetArea());
            //}
        }
    }
}
