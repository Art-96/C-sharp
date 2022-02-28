using System;

namespace Exceptions
{
    // To create a custom exclusion, inheritance is required by System.Exception.
    class UserException : Exception
    {
        public void Method()
        {
            Console.WriteLine("My exception!");
        }
    }
    class Program
    {
        static void Main()
        {
            try
            {
                throw new UserException();
            }
            catch (UserException e)
            {
                Console.WriteLine("Exception processing.");
                e.Method();
            }
        }
    }
}
