using System;

// Dynamic types of arguments and return values of methods.

namespace Dynamic
{
    class Program
    {
        static dynamic Method (dynamic arg)
        {
            return "Hello " + arg + "!";
        }
        static void Main()
        {
            string @string = Method("World");

            Console.WriteLine(@string);
        }
    }
}
