using System;

namespace GenericsConstraints
{
    class MyClass1<T> where T : class // The type argument must be of a reference type.
    {
        public T variable;
    }

    class MyClass2<T> where T : struct // The type argument must be of a value type.
    {
        public T variable;
    }

    class Program
    {
        static void Main()
        {
            MyClass1<string> instance1 = new MyClass1<string>();

            MyClass2<int> instance2 = new MyClass2<int>();
        }
    }
}
