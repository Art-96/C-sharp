using System;

namespace Exceptions
{
    class Program
    {
        static void Main()
        {
            try
            {
                throw new Exception("My exception");
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception processing.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
