using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string @string = "Hello";

            Console.WriteLine("Enter your username: ");

            string login = Console.ReadLine();

            @string += login == "Admin" ? "Administrator" : "User";

            Console.WriteLine(@string);

            Console.ReadKey();
        }
    }
}
