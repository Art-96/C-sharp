using System;

namespace StaticMembers
{
    abstract class AbstractClass
    {
        public static AbstractClass CreateObject()
        {
            return new ConcreteClass();
        }

        public abstract void Method();
    }
}
