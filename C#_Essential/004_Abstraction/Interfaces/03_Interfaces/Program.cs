using System;

// Explicit specification of the interface name in the method name.

namespace Interfaces
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();

            //instance. -- // On the instance, we do not see the methods of the interfaces.

            // Let's cast an instance of the class DerivedClass - instance, to the base interface type Interface1

            Interface1 instance1 = instance as Interface1;
            instance1.Method();

            Interface2 instance2 = instance as Interface2;
            instance2.Method();

            //Delay.
            Console.ReadKey();

        }
    }
}
