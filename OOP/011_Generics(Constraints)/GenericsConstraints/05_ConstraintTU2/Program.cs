using System;

namespace GenericsConstraints
{
    interface IInterface { /* ... */ }
    interface IInterface<U> : IInterface { /* ... */ }

    class Derived : IInterface, IInterface<object> { /* ... */ }

    class Derived2 : IInterface<object> { /* ... */ }

    class MyClass<T> where T : IInterface, IInterface<object> { /* ... */ }

    class MyClass2<T> where T : IInterface<object> { /* ... */ }

    class Program
    {
        static void Main()
        {
            MyClass<Derived> my1 = new MyClass<Derived>();
            //MyClass<IInterface> my1 = new MyClass<IInterface>();   // unacceptable

            // IInterface<object> inherited from IInterface
            MyClass<IInterface<object>> my2 = new MyClass<IInterface<object>>();

            MyClass2<Derived> my3 = new MyClass2<Derived>();
            MyClass2<Derived2> my4 = new MyClass2<Derived2>();
            MyClass2<IInterface<object>> my5 = new MyClass2<IInterface<object>>();
        }
    }
}
