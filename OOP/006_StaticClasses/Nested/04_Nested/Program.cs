using System;

namespace Nested
{
    public class MyClass // Inheritance from BaseClass is not distributed by.
    {
        public class Nested : BaseClass
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

            instance.MethodFromBase();
            instance.MethodFromNested();

            // Delay.
            Console.ReadKey();
        }
    }
}
