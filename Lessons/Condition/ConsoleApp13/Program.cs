using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day of the week: 1-2-3-4-5-6-7: ");

            string myday = Console.ReadLine();

            int day = Convert.ToInt32(myday);

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday.");
                    break;
                case 2:
                    Console.WriteLine("Tuesday.");
                    break;
                case 3:
                    Console.WriteLine("Wednesday.");
                    break;
                case 4:
                    Console.WriteLine("Thursday.");
                    break;
                case 5:
                    Console.WriteLine("Friday.");
                    break;
                case 6:
                    Console.WriteLine("Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Sunday.");
                    break;
                default:
                    Console.WriteLine("You entered a non-existent day of the week.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
