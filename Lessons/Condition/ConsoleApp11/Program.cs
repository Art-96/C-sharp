using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantity = 10;
            double price = 100;
            double discount = 0.75;
            double cost;

            cost = quantity >= 10 ? quantity * price * discount : quantity * price;

            Console.WriteLine("The total value of the goods is: {0} conventional units", cost);

            Console.ReadKey();
        }
    }
}
