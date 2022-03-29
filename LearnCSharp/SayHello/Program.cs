using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestConsoleProperty();
            Console.WriteLine("Hello!");
            TestInputAndOutput();
            Console.Beep();
            Console.ReadKey();
            //Console.ReadKey(true);
            //Console.ReadKey();
        }

        static void TestConsoleProperty()
        {
            Console.Title = "Current Time : " + DateTime.Now;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }

        static void TestInputAndOutput()
        {
            Console.Write("Please input a string:");
            String userInput = Console.ReadLine();

            Console.WriteLine("User Input:\t{0}   \nLength:{1}", userInput, userInput.Length);
        }


    }
}
