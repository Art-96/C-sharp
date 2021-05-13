using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day of the week: 1-2-3-4-5-6-7: ");

            string day = Console.ReadLine();

            switch (day)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                    Console.WriteLine("This day of the week is working.");
                    break;
                case "6":
                case "7":
                    Console.WriteLine("This day of the week is a day off.");
                    break;
                default:
                    Console.WriteLine("You entered a non-existent day of the week.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
