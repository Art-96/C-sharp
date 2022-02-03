using System;

namespace GenericsConstraints
{
    interface IInterface { /* ... */ }
    interface IInterface<U> { /* ... */ }

    class Derived : IInterface, IInterface<object> { /* ... */ }

    // The type argument must be or implement the specified interface.
    class MyClass<T> where T : IInterface, IInterface<object> { /* ... */ }

    class MyClass2<T> where T : IInterface { /* ... */ }

    class MyClass3<T> where T : IInterface<object> { /* ... */ }

    class Program
    {
        static void Main()
        {
            MyClass<Derived> mc1 = new MyClass<Derived>(); // Derived is inherited from both interfaces.

            MyClass2<IInterface> my2 = new MyClass2<IInterface>();
            MyClass2<Derived> my3 = new MyClass2<Derived>();

            MyClass3<IInterface<object>> my4 = new MyClass3<IInterface<object>>();
            MyClass3<Derived> my5 = new MyClass3<Derived>();
        }
    }
}
