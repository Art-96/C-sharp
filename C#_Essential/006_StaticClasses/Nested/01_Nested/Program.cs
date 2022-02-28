using System;

namespace Nested
{
    class MyClass
    {
        public class Nested
        {
            public void Method()
            {
                Console.WriteLine("Method from Nested class");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass.Nested instance = new MyClass.Nested();

            instance.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
