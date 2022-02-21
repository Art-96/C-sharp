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
            new
            {
                my = new MyClass { field = 1 }
            }.my.Method();
        }
    }
}
