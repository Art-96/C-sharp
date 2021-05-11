using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // local area
            {
                int a = 1;
                Console.WriteLine(a);
            }
            {
                int a = 2;
                Console.WriteLine(a);
            }

            // int a = 5; // error: a variable with this name exists in the local scope
            Console.ReadKey();
        }
    }
}
