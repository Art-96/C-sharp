using System;
using System.IO;

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
                Console.WriteLine("Exception processing.");
                userException.Method();

                try
                {
                    FileStream fs = File.Open(@"C:\NonExistentFile.log", FileMode.Open);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
