using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "Admin",
                password = "P@ssword";

            Console.Write("Enter login: ");

            string usersLogin = Console.ReadLine();

            if (login == usersLogin)
            {
                Console.Write("Enter Password: ");
                string usersPassword = Console.ReadLine();

                if (password == usersPassword)
                {
                    Console.WriteLine("Welcom {0}, you are logged in.", usersLogin);
                }
                else
                {
                    Console.WriteLine("You entered an incorrect password.");
                }
            }
            else
            {
                Console.WriteLine("There is no user with that name.");
            }

            Console.ReadKey();
        }
    }
}
