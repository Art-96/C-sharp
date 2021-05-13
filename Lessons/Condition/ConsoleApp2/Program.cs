using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 2;

            if (a < b)
            {
                Console.WriteLine("a < b");
            }
            else
            {
                Console.WriteLine("a is not less than b");
            }

            Console.ReadKey();
        }
    }
}
