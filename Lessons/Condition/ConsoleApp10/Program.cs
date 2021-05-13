using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = -5;

            // nesting ternary operators is not recommended

            string quadrant = (x > 0) ? ((y > 0) ? "I square" : "IV square") : ((y > 0) ? "II square" : "III square");

            // or

            quadrant = x > 0 ? (y > 0 ? "I square" : "IV square") : (y > 0 ? "II square" : "III square");

            // or

            quadrant = x > 0 ? y > 0 ? "I square" : "IV square" : y > 0 ? "II square" : "III square";

            Console.WriteLine(quadrant);

            Console.ReadKey();
        }
    }
}
