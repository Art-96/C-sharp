using System;

// Dynamic data types. (Local variables)

namespace Dynamic
{
    class Program
    {
        static void Main()
        {
            dynamic variable = 1;

            Console.WriteLine(variable);

            variable = "Hello World";

            Console.WriteLine(variable);

            variable = DateTime.Now;

            Console.WriteLine(variable);
        }
    }
}
