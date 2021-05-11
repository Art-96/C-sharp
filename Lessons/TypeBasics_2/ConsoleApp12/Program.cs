using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 127;

            unchecked
            {
                a++;
            }

            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
