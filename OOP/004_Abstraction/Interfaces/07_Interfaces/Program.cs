using System;

namespace Interfaces
{
    interface IInterface1
    {
        void Method();
    }

    interface IInterface2
    {
        void Method();
    }

    class ConcreteClass : IInterface1, IInterface2
    {
        public void Method()
        {
            Console.WriteLine("Method1 - implementation of the IInterface (1-2) interface.");
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
