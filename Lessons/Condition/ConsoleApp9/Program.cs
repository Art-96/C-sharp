using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int max;
            double b = 0.0;

            max = (int)((a > b) ? a : b);

            max = (a > b) ? a : (int)b;

            Console.WriteLine(max);

            Console.ReadKey();
        }
    }
}
