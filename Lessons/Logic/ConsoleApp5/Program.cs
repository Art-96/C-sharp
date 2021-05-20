using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0, B = 5, x = 3;

            if (A < x && x < B)
            {
                Console.WriteLine("Number {0} is in the range of numbers from {1} to {2}.", x, A, B);
            }
            else
            {
                Console.WriteLine("Number {0} is in the range of numbers from {1} to {2}.", x, A, B);
            }

            Console.ReadKey();
        }
    }
}
