using System;

namespace Exceptions
{
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
            catch(UserException userException)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Exception Handling 1:");
                userException.Method();

                try
                {
                    throw userException;
                }
                catch (UserException exception)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Exception Handling 2:");
                    exception.Method();
                }
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.WriteLine("Press any key...");
        }
    }
}
