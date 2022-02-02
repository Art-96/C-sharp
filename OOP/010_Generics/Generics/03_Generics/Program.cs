using System;

// Generic Method

namespace Generics
{
    class MyClass
    {
        public void Method<T>(T argument)
        {
            T variable = argument;
            Console.WriteLine(variable);
        }
    }
    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();
            
            instance.Method<string>("Hello World");

            instance.Method("Hello");
        }
    }
}
