using System;

namespace Delegation
{
    class A
    {
        public void DoSomething()
        {
            Console.WriteLine("Action");
        }

    }

    class B
    {
        public void DoSomething()
        {
            A instance = new A();

            instance.DoSomething();
        }
    }

    class Program
    {
        static void Main()
        {
            B instance = new B();

            instance.DoSomething();

            // Delay.
            Console.ReadKey();
        }
    }
}
