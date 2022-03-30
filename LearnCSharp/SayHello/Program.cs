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
            DateTime d1 = new DateTime(1997, 2, 10);
            DateTime d2 = new DateTime(2022, 3, 30);

            double days = (d2 - d1).TotalDays;

            string str = "{0}年{1}月{2}日到{3}年{4}月{5}日共有天数：";
            str = String.Format(str, d1.Year, d1.Month, d1.Day, d2.Year, d2.Month, d2.Day);
            Console.WriteLine(str + days);

            Console.ReadKey();

            //TestConsoleProperty();
            //Console.WriteLine("Hello!");
            //TestInputAndOutput();
            //Console.Beep();
            //Console.ReadKey();
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
