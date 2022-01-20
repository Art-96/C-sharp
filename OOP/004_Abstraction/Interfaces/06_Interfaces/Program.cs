using System;

namespace Interfaces
{
    interface IInterface1
    {
        void Method();
    }

    interface IInterface2 : IInterface1
    {
        // Without new - there will be no error, but there will be a compiler warning.
        new void Method();
    }

    class ConcreteClass : IInterface2
    {
        void IInterface1.Method()
        {
            Console.WriteLine("Method1 - implementation of the IInterface1 interface.");
        }

        void IInterface2.Method()
        {
            Console.WriteLine("Method2 - implementation of the IInterface2 interface.");
        }
    }
    class Program
    {
        static void Main()
        {
            ConcreteClass instance = new ConcreteClass();
            //instance.Method();

            IInterface1 instance1 = instance as IInterface1;
            instance1.Method();

            IInterface2 instance2 = instance as IInterface2;
            instance2.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
