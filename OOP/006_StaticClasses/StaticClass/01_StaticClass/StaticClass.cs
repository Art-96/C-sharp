using System;

// A static class in C# expresses the idea of a design pattern - Singleton.

// Rules:
// 1. An instance of a static class cannot be instantiated.
// 2. A static class always inherits from Object (Attempting to inherit from something else results in a compilation error).
// 3. Static class does not implement interfaces. Attempting to inherit from an interface results in a compile-level error.
// 4. Contains only static members (having a non-static member in it will result in a compilation error).
// 5. A static class cannot contain instance constructors.
// 6. A static class is closed to inherit from it. Attempting to inherit from a static class results in a compile-level error.

namespace StaticClass
{
    static class StaticClass
    {
        // Instance constructor - unacceptable.
        // public StaticClass()
        // {
        //    Console.WriteLine("Constructor.");
        // }

        static StaticClass()
        {
            Console.WriteLine("Static Constructor");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("StaticMethod");
        }

        // non-static method - unacceptable.
        // public void NotStaticMethod()
        // {
        //    Console.WriteLine("NotStaticMethod");
        // }
    }
}
