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
            ChooseAnswerCorrect();

        }


        public static void ChooseAnswerCorrect()
        {
            Console.WriteLine("What is the keyboard in c# to finish a loop(while,for)");
            char answer = 'a';
            Console.WriteLine("a. int");
            Console.WriteLine("b. continue");
            Console.WriteLine("c. break");
            Console.WriteLine("d. exit");
            while ( answer != 'c')
            {
                Console.WriteLine("Enter choice:");
                answer = Console.ReadLine().First();
                if (answer != 'c')
                {
                    Console.WriteLine("Incorrect Answer");
                }
                else
                {
                    Console.WriteLine("Correct Answer");
                }
            }
            Console.WriteLine("Finish Program");
        }
    }
}
