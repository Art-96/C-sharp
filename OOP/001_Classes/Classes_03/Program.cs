using System;

// Weak reference instantiation. (Anonymous objects)

namespace Classes_03
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new MyClass().Method();

            // Delay
            Console.ReadKey();
        }
    }
}
