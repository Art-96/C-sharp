using System;

// Finally - does not work if the Catch block is not completed.

namespace Exceptions
{
    class Program
    {
        static void Main()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception)
            {
                throw new Exception();

                // or ...

                while (true)
                    Console.WriteLine("Catch");
            }
            finally
            {
                while (true)
                    Console.WriteLine("Finally");
            }
        }
    }
}
