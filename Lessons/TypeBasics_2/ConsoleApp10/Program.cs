using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            byte summand1 = 1, summand2 = 2;
            int sum = 0;
            sum = summand1 + summand2;

            Console.WriteLine(sum);


            byte minuend = 5, subtrahend = 3;
            int difference = 0;
            difference = minuend - subtrahend;

            Console.WriteLine(difference);


            byte factor1 = 2, factor2 = 3;
            int product = 0;
            product = factor1 * factor2;

            Console.WriteLine(product);


            byte dividend = 5, divisor = 2;
            int quotient = 0, remainder = 0;
            quotient = dividend / divisor;

            Console.WriteLine(quotient);

            remainder = dividend % divisor;

            Console.WriteLine(remainder);
        }
    }
}
