using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int doubleSize = sizeof(double);
            Console.WriteLine("Size type double: {0} byte", doubleSize);

            Console.WriteLine("Size type int: {0} byte", sizeof(int));
            Console.WriteLine("Size type bool: {0} byte", sizeof(bool));
            Console.WriteLine("Size type long: {0} byte", sizeof(long));
            Console.WriteLine("Size type short: {0} byte", sizeof(short));


            Console.ReadKey();
        }
    }
}
