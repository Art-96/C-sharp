using System;

// C# only allows multiple inheritance from interfaces.
// Multiple implementation inheritance (that is, from two or more classes or structures) is not allowed.
// Multiple inheritance from one class and many interfaces is allowed.

namespace Interfaces
{
    class DerivedClass : BaseClass, Interface1, Interface2
    {
        public void Method1()
        {
            Console.WriteLine("Implementation of the Method1() method from Interface1");
        }

        public void Method2()
        {
            Console.WriteLine("Implementation of the Method2() method from Interface2");
        }
    }
}
