using System;

namespace Generics
{
    class MyClass<T>
    {
        public T field;

        public void Method()
        {
            Console.WriteLine(field.GetType());
        }
    }
    class Program
    {
        static void Main()
        {
            MyClass<int> instance1 = new MyClass<int>();
            instance1.Method();

            MyClass<string> instance2 = new MyClass<string>();
            instance2.field = "Hello";
            instance2.Method();
        }
    }
}
