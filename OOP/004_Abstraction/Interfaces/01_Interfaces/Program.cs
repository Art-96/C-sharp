using System;

namespace Interfaces
{
    interface IInterface
    {
        void Method();
    }

    class MyClass : IInterface
    {
        public void Method()
        {
            Console.WriteLine("Method - implementation of the Interface.");
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            instance.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
