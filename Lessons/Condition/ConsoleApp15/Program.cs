using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coffee cups size: 1 = small, 2 = middle, 3 = middle");
            Console.Write("Please make your choice: ");

            string coffeesize = Console.ReadLine();

            int cost = 0;

            switch (coffeesize)
            {
                case "1":
                    cost += 25;
                    break;
                case "2":
                    cost += 25;
                    goto case "1";
                case "3":
                    cost += 50;
                    goto case "1";
                default:
                    Console.WriteLine("Wrong choice. Please choose 1, 2, or 3.");
                    break;
            }

            if (cost != 0)
            {
                Console.WriteLine("Deposit {0} kopeck.", cost);
                Console.WriteLine("Thanks.");
            }
            else
            {
                Console.WriteLine("Please, repeat selection.");
            }
        }
    }
}
