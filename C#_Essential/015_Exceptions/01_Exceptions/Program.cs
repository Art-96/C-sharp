using System;

namespace Exceptions
{
    class Program
    {
        static void Main()
        {
            int a = 1, n = 2;

            try
            {
                a = a / (2 - n);

                Console.WriteLine("a = {0}", a);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception processing.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
