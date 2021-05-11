using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = false;

            int a = 1;
            float b = 2.0f;
            result = a < b;

            string c = "Hello"; // matching a value of int types with a value of type string is not allowed

            Console.ReadKey();
        }
    }
}
