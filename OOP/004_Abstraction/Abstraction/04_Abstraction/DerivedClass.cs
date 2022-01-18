using System;

namespace Abstraction
{
    class ConcreteDerivedClass : AbstractBaseClass
    {
        public override void VirtualMethod()
        {
            Console.WriteLine("DerivedClass.VirtualMethod();");
        }

        public override void AbstractMethod()
        {
            Console.WriteLine("DerivedClass.AbstractMethod();");
        }
    }
}
