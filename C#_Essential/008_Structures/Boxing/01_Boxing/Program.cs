using System;

// Boxing - conversion of a structural type (value type) to a reference type

// Unboxing - conversion of a reference type to a structural type.
// The unboxing-conversion operation extracts the value type from the object.

namespace Boxing
{
    class Program
    {
        static void Main()
        {
            short a = 25;

            // Boxing
            object o = a;

            // UnBoxing
            short b = (short)o;

            // Unpacking should be done only in the type from which the packaging was made.
            //byte s = (byte)o;

            // Delay.
            Console.ReadKey();
        }
    }
}
