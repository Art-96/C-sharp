using System;

namespace Inheritance
{
    class DerivedClass : BaseClass
    {
        // Overriding a base class method.
        public override void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }
    }
}
