using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int MIN_VALUE = 1;
            int denominator = 0;
            int item = 2;


            if (((item / denominator) > MIN_VALUE) && (denominator != 0))
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
