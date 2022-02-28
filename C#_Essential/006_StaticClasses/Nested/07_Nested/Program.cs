using System;

// Non-static classes can contain static Nested classes.

namespace Nested
{
    public class MyClass
    {
        public static class Nested
        {
            public static void StaticMethodFromNested()
            {
                Console.WriteLine("The static method of the Nested class.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass.Nested.StaticMethodFromNested();

            // Delay.
            Console.ReadKey();
        }
    }
}
