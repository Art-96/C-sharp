using System;

namespace Inheritance
{
    class DerivedClass : BaseClass
    {
        // Overriding a base class method.

        public override void Method()
        {
            // Calling a base class method.
            base.Method();

            Console.WriteLine("Method from DerivedClass");
        }
    }
}
