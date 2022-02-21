using System;

namespace Anonymous
{
    class MyClass
    {
        public int field;

        public void Method()
        {
            Console.WriteLine(field);
        }
    }

    class Program
    {
        static void Main()
        {
            var instance = new { my = new MyClass() };

            instance.my.field = 1;
            instance.my.Method();
        }
    }
}
