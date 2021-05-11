using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //increment
            byte number1 = 0;
            Console.WriteLine(number1++);
            Console.WriteLine(number1);

            byte number2 = 0;
            Console.WriteLine(++number2);

            // decrement
            sbyte number3 = 0;
            Console.WriteLine(number3--);
            Console.WriteLine(number3);

            sbyte number4 = 0;
            Console.WriteLine(--number4);

            Console.ReadKey();
        }
    }
}
