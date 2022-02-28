using System;

// An abstract class can be inherited from an abstract class.
// The implementation of an abstract method from a base abstract class in a derived abstract class is optional.

namespace Abstraction
{
    abstract class AbstractClassA
    {
        public abstract void OperationA();
    }   

    abstract class AbstractClassB : AbstractClassA
    {
        public abstract void OperationB();
    }

    class ConcreteClass : AbstractClassB
    {
        public override void OperationA()
        {
            Console.WriteLine("ConcreteClass.OperationA");
        }
        public override void OperationB()
        {
            Console.WriteLine("ConcreteClass.OperationB");
        }
    }

    class Program
    {
        static void Main()
        {
            AbstractClassA instance = new ConcreteClass();

            instance.OperationA();

            // instance.OperationB();

            // Delay.
            Console.ReadKey();
        }
    }
}
