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
            Console.ReadKey();
        }

        static void TestConsoleProperty()
        {
            Console.Title = "Current Time : " + DateTime.Now;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
    }
}
