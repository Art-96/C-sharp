using System;

namespace Interfaces
{
    interface Interface
    {
        void Method();
    }

    abstract class AbstractClass : Interface
    {
        // Replacing an abstract method from an interface in an abstract class is mandatory.
        public abstract void Method();
    }

    class ConcreteClass : AbstractClass
    {
        // The implementation of an abstract method from an abstract class in a concrete class is required.
        public override void Method()
        {
            Console.WriteLine("Method - implementation of an interface in an abstract class.");
        }
    }
    class Program
    {
        static void Main()
        {
            ConcreteClass instance = new ConcreteClass();
            instance.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
