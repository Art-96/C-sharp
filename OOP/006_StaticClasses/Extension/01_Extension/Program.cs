using System;

// Extension methods can only be static and can only be created in static classes.

namespace Extension
{
    static class ExtensionClass
    {
        // this - tells the compiler that this method is an extension method (Extension)!
        public static void ExtensionMethod(this string value)
        {
            Console.WriteLine(value);
        }
    }
    class Program
    {
        static void Main()
        {
            string text = "Test string";

            ExtensionClass.ExtensionMethod(text);

            text.ExtensionMethod();

            // Delay.
            Console.ReadKey();
        }
    }
}
