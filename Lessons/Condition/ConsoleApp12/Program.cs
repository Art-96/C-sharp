using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1 or 2: ");

            string number = Console.ReadLine();

            switch (number)
            {
                case "1":
                    {
                        Console.WriteLine("One");
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("two");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You entered a value other than 1 and 2.");
                        break;
                    }
            }

        }
    }
}
