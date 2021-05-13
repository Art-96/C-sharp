using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 2;

            if (a < b)
            {
                Console.WriteLine("a < b");
            }
            else if (a > b)
            {
                Console.WriteLine("a > b");
            }
            else
            {
                Console.WriteLine("a == b");
            }

            Console.ReadKey();
        }
    }
}
