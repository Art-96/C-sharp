using System;

namespace Nested
{
    public class MyClass : BaseClass
    {
        public class Nested // Inheritance from BaseClass is not distributed by.
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
            MyClass instance1 = new MyClass();
            instance1.MethodFromBase();

            MyClass.Nested instance2 = new MyClass.Nested();
            instance2.MethodFromNested();

            // Delay.
            Console.ReadKey();
        }
    }
}
