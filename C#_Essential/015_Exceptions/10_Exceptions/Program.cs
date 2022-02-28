using System;

// Finally - does not work when the StackOverFlowException exception occurs.

namespace Exceptions
{
    class Program
    {
        public static void Method()
        {
            int[] arr = new int[10];
            Console.WriteLine(arr);
            Method();
        }

        static void Main()
        {
            try
            {
                Method();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                while (true)
                    Console.WriteLine("Finally");
            }
        }
    }
}
