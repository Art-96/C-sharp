using System;

// The extension argument must always be only one and come first in the argument list.

namespace Extension
{
    static class ExtensionClass
    {
        public static void ExtensionMethod(this string value1, string value2)
        {
            Console.WriteLine(value1 + value2);
        }
    }

    class Program
    {
        static void Main()
        {
            string text = "Hello ";

            text.ExtensionMethod("World!");

            // Delay.
            Console.ReadKey();
        }
    }
}
