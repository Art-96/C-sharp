using System;

// An abstract class can be inherited from a concrete class.

namespace Abstraction
{
    class ConcreteClassA
    {
        public void Operation()
        {
            Console.WriteLine("ConcreteClassA.Operation");
        }
    }

    abstract class AbstractClass : ConcreteClassA
    {
        public abstract void Method();
    }

    class ConcreteClassB : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("ConcreteClassB.Method");
        }
    }

    class Program
    {
        static void Main()
        {
            AbstractClass instance = new ConcreteClassB();

            instance.Method();
            instance.Operation();

            // Delay.
            Console.ReadKey();
        }
    }
}
