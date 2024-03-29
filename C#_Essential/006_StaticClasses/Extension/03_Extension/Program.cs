﻿using System;

// Extension methods cannot have optional parameters, but can be overloaded.

namespace Extension
{
    static class ExtensionClass
    {
        public static void ExtensionMethod(this string value)
        {
            Console.WriteLine(value);
        }
        public static void ExtensionMethod(this string value1, string value2)
        {
            Console.WriteLine(value1 + value2);
        }
        public static void ExtensionMethod(this int value)
        {
            Console.WriteLine(value);
        }
    }

    class Program
    {
        static void Main()
        {
            string text = "Hello ";

            text.ExtensionMethod("world!");

            "Hello ".ExtensionMethod("world!");
            2.ExtensionMethod();

            // Delay.
            Console.ReadKey();
        }
    }
}
