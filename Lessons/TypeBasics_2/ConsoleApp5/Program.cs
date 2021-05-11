using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            byte value1 = 0, value2 = 1;
            bool result = false;


            result = value1 < value2;
            Console.WriteLine(result);

            result = value1 > value2;
            Console.WriteLine(result);

            result = value1 <= value2;
            Console.WriteLine(result);

            result = value1 >= value2;
            Console.WriteLine(result);

            result = value1 == value2;
            Console.WriteLine(result);

            result = value1 != value2;
            Console.WriteLine(result);
        }
    }
}
