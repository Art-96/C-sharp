using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialClass instance = new PartialClass();

            instance.MethodFromPart1(); // Method from the first part of the PartialClass
            instance.MethodFromPart2(); // Method from the second part of the PartialClass

            // Delay.
            Console.ReadKey();
        }
    }
}
