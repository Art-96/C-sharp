using System;

// Partial methods

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialClass instance = new PartialClass();

            instance.CallPartialMethod();

            // Delay.
            Console.ReadKey();
        }
    }
}
