using System;

// An object cannot hide (encapsulate) anything from another object of the same class.

namespace Classes
{
    class MyClass
    {
        MyClass my = null;

        private void Method()
        {
            Console.WriteLine("Hello");
        }

        public void CallMethod()
        {
            my = new MyClass();

            // private method is visible on the instance!
            my.Method();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my.CallMethod();
            // my.Method(); // Unacceptable

            // Delay.
            Console.ReadKey();
        }
    }
}
