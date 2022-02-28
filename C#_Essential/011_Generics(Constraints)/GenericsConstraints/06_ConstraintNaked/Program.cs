using System;

namespace GenericsConstraints
{
    // The type argument supplied as T must be the same as or derived from the type argument supplied as U.
    class MyClass<T, R, U> where T : U
    {
    }

    class Program
    {
        static void Main()
        {
            MyClass<int, Object, int> my1 = new MyClass<int, Object, int>();

            MyClass<string, Object, string> my2 = new MyClass<string, Object, string>();
        }
    }
}
