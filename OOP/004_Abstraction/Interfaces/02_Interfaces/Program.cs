using System;

namespace Interfaces
{
    class Program
    {
        static void Main()
        {
            Interface1 instance1 = new DerivedClass();
            Interface2 instance2 = new DerivedClass();

            instance1.Method1();

            instance2.Method2();

            // Delay.
            Console.ReadKey();
        }
    }
}
