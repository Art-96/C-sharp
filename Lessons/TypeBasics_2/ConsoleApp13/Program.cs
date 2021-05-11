using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 126;
            sbyte b = 127;

            checked
            {
                a++;

                unchecked
                {
                    b++;
                }

                a++;
            }

            Console.ReadKey();
        }
    }
}
