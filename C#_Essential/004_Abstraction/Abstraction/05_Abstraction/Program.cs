using System;

namespace Abstraction
{
    abstract class AbstractClass
    {
        public AbstractClass()
        {
            Console.WriteLine("1 AbstractClass()");

            // The implementation of the method from the derived class is called - ConcreteClass.
            this.AbstractMethod();

            Console.WriteLine("2 AbstractClass()");
        }

        public abstract void AbstractMethod();
    }

    class ConcreteClass : AbstractClass
    {
        string s = "FIRST";

        public ConcreteClass()
        {
            Console.WriteLine("3 ConcreteClass()");
            s = "SECOND";
        }

        public override void AbstractMethod()
        {
            Console.WriteLine("Method Implementation AbstractMethod() in ConcreteClass  {0}", s);
        }
    }

    class Program
    {
        static void Main()
        {
            AbstractClass instance = new ConcreteClass();

            Console.WriteLine(new string('-', 55));

            instance.AbstractMethod();

            // Delay.
            Console.ReadKey();
        }
    }
}
