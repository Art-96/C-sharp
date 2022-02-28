using System;

namespace Interfaces
{
    class DerivedClass : Interface1, Interface2
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
