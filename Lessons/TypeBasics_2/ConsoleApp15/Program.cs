using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Console.WriteLine("This number {0}", a);

            int b = 2, c = 3;
            Console.WriteLine("These are numbers {0} and {1}", b, c);
            Console.WriteLine("These are numbers in reverse {1} and {0}", b, c);

            Console.ReadKey();
        }
    }
}
