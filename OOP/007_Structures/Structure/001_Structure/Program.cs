using System;

// Structs cannot initialize fields directly at the point of creation.

namespace Structure
{
    struct MyStruct
    {
        public int field;
    }

    class Program
    {
        static void Main()
        {
            // Creating an instance of a structural type without calling a constructor.
            MyStruct instance;

            instance.field = 1;

            // Attempting to display the value of an uninitialized field will result in an error.
            Console.WriteLine(instance.field);

            // Delay.
            Console.ReadKey();
        }
    }
}
