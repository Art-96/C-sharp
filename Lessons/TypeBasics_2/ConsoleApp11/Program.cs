using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 127;

            // overflow check
            checked
            {
                a++; //error
            }

            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
