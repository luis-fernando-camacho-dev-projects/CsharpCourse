using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowNumberWithAngles();
        }

        public static void ShowNumberWithAngles()
        {
            int i = 1;
            while (i < 10)
            {
                int j = 1;
                while (j <= i)
                {
                    Console.Write(j);
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}
