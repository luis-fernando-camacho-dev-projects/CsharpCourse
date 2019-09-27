using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitcthAPP
{
    class Program
    {
        static void PrintPyramid()
        {
            Console.WriteLine("*");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Exercise4()
        {
            Console.WriteLine("Number to Read");
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insert Number :" + (i+1));
                int numberToRead = int.Parse(Console.ReadLine());
                sum = sum + numberToRead;
            }
            Console.WriteLine("Total sum" + sum);
            Console.WriteLine(" Average "+ (sum/10));
        }

        static void Exercise3()
        {
            Console.WriteLine("insert Term");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i; // sum+=i;
            }
            Console.WriteLine(sum);
        }

        static void ForExampleDecrement(int n)
        {
            for (int i = n; i != 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void ForExample(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
        }


        public static void ShowTextMark()
        {
            Console.WriteLine("Insert Number");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 9: case 10:
                {
                    Console.WriteLine("Sobresaliente");
                    break;

                }
                case 7:
                case 8:
                    {
                        Console.WriteLine("Notable");
                        break;

                    }
                case 6:
                {
                    Console.WriteLine("Bien");
                    break;
                }
                case 5:
                {
                    Console.WriteLine("Aprobado");
                    break;
                }
                case 0:
                case 4:
                {
                    Console.WriteLine("Suspenso");
                    break;
                }
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }

        static void Main(string[] args)
        {
            PrintPyramid();
            //Exercise4();
            //Exercise3();
            //ForExampleDecrement(5);
            //ForExample(5);
            //ShowTextMark();
            //Console.WriteLine("Insert a Key");
            //int number = int.Parse(Console.ReadLine());
            //switch (number)
            //{
            //    case 0:
            //    {
            //        Console.WriteLine("One");
            //        break;
            //    }
            //    case 1:
            //    {
            //        Console.WriteLine("One");
            //        break;
            //    }
            //    case 2:
            //    {
            //        Console.WriteLine("Two");
            //        break;
            //    }
            //    case 3:
            //    {
            //        Console.WriteLine("Three");
            //        break;
            //    }
            //    case 4:
            //    {
            //        Console.WriteLine("Four");
            //        break;
            //    }
            //    case 5:
            //    {
            //        Console.WriteLine("Five");
            //        break;
            //    }
            //    case 6:
            //    {
            //        Console.WriteLine("six");
            //        break;
            //    }
            //    case 7:
            //    {
            //        Console.WriteLine("seven");
            //        break;
            //    }
            //    case 8:
            //    {
            //        Console.WriteLine("eight");
            //        break;
            //    }
            //    case 9:
            //    {
            //        Console.WriteLine("nine");
            //        break;
            //    }
            //    default:
            //        Console.WriteLine("Not Allowed");
            //        break;
            //}
        }
    }
}
