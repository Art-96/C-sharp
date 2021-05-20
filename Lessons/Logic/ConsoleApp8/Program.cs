using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int MIN_VALUE = 1;
            int denominator = 0;
            int item = 2;


            if ((denominator != 0) && (item / denominator) > MIN_VALUE)
            {
                Console.WriteLine("We are in the block IF");
            }
            else
            {
                Console.WriteLine("We are in the block ELSE");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
