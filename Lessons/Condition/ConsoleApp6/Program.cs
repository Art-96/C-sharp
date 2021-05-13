using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, max = 0;

            max = (a > b) ? a : b;

            Console.WriteLine(max);

            Console.ReadKey();
        }
    }
}
