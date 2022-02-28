using System;

// Structures cannot be inherited.

namespace Inheritance
{
    struct MyStruct
    {
        // Structs cannot have protected members.
        // protected int field;
    }

    class MyClass //: MyStruct
    {
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Structures cannot be inherited.");

            // Delay.
            Console.ReadKey();
        }
    }
}
