using System;

namespace Interfaces
{
    class DerivedClass : Interface1, Interface2
    {
        // On the 13th line, we implement a method named Method from the base interface Interface1
        // When implementing a method, we use the technique of explicitly specifying the interface name
        // in the name of the method to which this method belongs.

        // By default, methods of the same name are private, but explicitly
        // specifying access modifiers is not allowed.
        void Interface1.Method()
        {
            Console.WriteLine("Implementation of the Method() method from Interface1");
        }

        void Interface2.Method()
        {
            Console.WriteLine("Implementation of the Method() method from Interface2");
        }
    }
}
