using System;

namespace Exceptions
{
    class Program
    {
        static void Main()
        {
            Exception ex = new Exception("My exception");

            try
            {
                throw ex;
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception processing.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
