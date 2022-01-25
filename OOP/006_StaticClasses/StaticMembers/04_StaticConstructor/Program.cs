using System;

namespace StaticMembers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(NotStaticClass.ReadonlyField);

            // Delay.
            Console.ReadKey();
        }
    }
}
