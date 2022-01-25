using System;

namespace StaticMembers
{
    class Program
    {
        static void Main()
        {
            AbstractClass instance = AbstractClass.CreateObject();
            instance.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
