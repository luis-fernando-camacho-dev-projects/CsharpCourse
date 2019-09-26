using System;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Insert a number");
            //int numberToRead = int.Parse(Console.ReadLine());
            //if (numberToRead < 5)
            //{
            //    if (numberToRead % 2 == 0)
            //    {
            //        Console.WriteLine("The number is odd(par)");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number is even(impar)");
            //    }
            //}
            //else if (numberToRead > 5)
            //{
            //    numberToRead = numberToRead + 1;
            //}
            //else
            //{
            //    numberToRead = 0;
            //}
            //Console.WriteLine(numberToRead);
            //Console.ReadLine();
            //CheckNumber();
            //Exercise6();
            //Exercise8();
            //Exercise9();
            Exercise11();
        }

        public static void CheckNumber()
        {
            Console.WriteLine("Insert a first number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the second number");
            int number2 = int.Parse(Console.ReadLine());
            if (number1 == number2)
            //if (number1.Equals(number2))
            {
                Console.WriteLine("the numbers are equals or are same");
            }
            else
            {
                Console.WriteLine("the numbers are different");
            }

            //+ 
            //-
            //*
            ///
            //%
            //(5>6)&&(6>7)
            // V && V =V
            // V && F =F
            // F && V = F
            // F && F = F

            
            // V || V = V
            // V || F = V
            // F || V = V
            // F || F = F
        }

        public static void Exercise6()
        {
            Console.WriteLine("Insert a Number");
            int m = int.Parse(Console.ReadLine());
            int n = 0;

            if (m > 0)
            {
                n = 1;
            }
            else if (m < 0)
            {
                n = -1;
            }
            else if( m == 0)
            {
                n = 0;
            }

            Console.WriteLine("Test ouput:"+ n);
        }

        public static void Exercise8()
        {
            Console.WriteLine("Insert Number 1");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert Number 2");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert Number 3");
            int number3 = int.Parse(Console.ReadLine());

            if ((number1 > number2) && (number1 > number3))
            {
                Console.WriteLine("Number 1 =" + number1 + " is greather than number2 and number3");
            }
            if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine("Number 2 =" + number2 + " is greather than number1 and number3");
            }
            if (number3 > number1 && number3 > number2)
            {
                Console.WriteLine("Number 3 =" + number3 + " is greather than number1 and number2");
            }
            if (number1 == number2 && number1 == number3)
            {
                Console.WriteLine("All numbers are equal");
            }

        }

        public static void Exercise9()
        {
            Console.WriteLine("Insert X");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert Y");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("The Coordenate (" + x + "," + y + ") lies in the First quadrant");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The Coordenate (" + x + "," + y + ") lies in the Second quadrant");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The Coordenate (" + x + "," + y + ") lies in the Thrid quadrant");
            }
            else
            {
                Console.WriteLine("The Coordenate (" + x + "," + y + ") lies in the Fourth quadrant");
            }
        }

        public static void Exercise11()
        {
            Console.WriteLine("insert math phy che grades");
            string grades = Console.ReadLine();
            string[] markGrades = grades.Split(' ');
            int math = int.Parse(markGrades[0]);
            int phy = int.Parse(markGrades[1]);
            int che = int.Parse(markGrades[2]);
            Console.WriteLine("Math grade:"+ math);
            Console.WriteLine("Phy grade:" + phy);
            Console.WriteLine("Che grade:" + che);

        }
    }
}
