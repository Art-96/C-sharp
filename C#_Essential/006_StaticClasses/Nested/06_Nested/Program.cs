using System;

// Static classes can contain non-static Nested classes.

namespace Nested
{
    public static class MyClass
    {
        static MyClass()
        {
            Console.WriteLine("Static constructor MyClass");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Static method of class MyClass");
        }

        public class Nested
        {
            public void MethodFromNested()
            {
                Console.WriteLine("Nested class method.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass.Nested instance = new MyClass.Nested();
            instance.MethodFromNested();

            Console.WriteLine(new string('-', 30));

            MyClass.StaticMethod();

            // Delay.
            Console.ReadKey();
        }
    }
}
