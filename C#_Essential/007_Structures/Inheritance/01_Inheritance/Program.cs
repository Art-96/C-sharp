using System;

// Struct inheritance is only allowed from interfaces.
// Inheritance of structures from classes and structures is prohibited.
// All structures are implicitly inherited from the abstract class - ValueType

namespace Inheritance
{
    interface IInterface
    {
        void Method();
    }

    struct MyStruct : IInterface
    {
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }

    class Program
    {
        static void Main()
        {
            MyStruct instance;

            instance.Method();

            MyStruct instance2 = new MyStruct();

            ValueType valueType = instance2 as ValueType;

            Console.WriteLine("instance  = {0}", instance2.GetHashCode());
            Console.WriteLine("valueType = {0}", valueType.GetHashCode());

            // Delay.
            Console.ReadKey();
        }
    }
}
