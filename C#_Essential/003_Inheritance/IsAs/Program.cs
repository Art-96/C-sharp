using System;

namespace Inheritance
{
    class ClassA { /* ... */ }

    class ClassB : ClassA { /* ... */ }
    class Program
    {
        static void Main()
        {
            ClassB b = new ClassB();
            ClassA a = null;

            //--------------------------------------------- is ---------------------------------------------
            // The is operator checks the compatibility of an object with a given type.
            // If the provided object can be cast to the provided type without throwing an exception,
            // the is expression evaluates to true.

            // For example, the following code determines whether an object is an instance of type A or a type derived from A:

            if (b is ClassA)
            {
                a = (ClassA)b;
            }
            else
            {
                a = null;
            }

            //--------------------------------------------- as---------------------------------------------
            // The as operator is used to perform conversions between compatible reference types.
            // The as operator is similar to the cast operator. However, if the conversion is not possible,
            // as returns null rather than throwing an exception.

            a = b as ClassA;

            // Delay.
            Console.ReadKey();
        }
    }
}
