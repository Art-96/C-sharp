using System;

namespace GenericsConstraints
{
    class Base { }
    class Derived : Base { }

    // The type argument must be or derive from the specified base class.
    class MyClass<T> where T : Base { }

    class Program
    {
        static void Main()
        {
            MyClass<Base> instance1 = new MyClass<Base>();

            MyClass<Derived> instance2 = new MyClass<Derived>();

            //MyClass<string> mc3 = new MyClass<string>();     // unacceptable
        }
    }
}
