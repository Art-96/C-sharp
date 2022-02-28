using System;

// Structs can create auto-implemented properties,
// requiring the use of a constructor when constructing an instance.

namespace Structure
{
    struct MyStruct
    {
        public int MyProperty { get; set; }
    }

    class Program
    {
        static void Main()
        {
            MyStruct instance = new MyStruct();

            instance.MyProperty = 1;
            Console.WriteLine(instance.MyProperty);

            // Delay.
            Console.ReadKey();
        }
    }
}
