using System;

namespace ClassObject
{
    class MyClass
    {
        public override string ToString()
        {
            return "Hello World";
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            Console.WriteLine(instance.ToString());
        }
    }
}
