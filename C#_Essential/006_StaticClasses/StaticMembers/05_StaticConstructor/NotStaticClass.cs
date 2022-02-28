using System;

namespace StaticMembers
{
    class NotStaticClass
    {
        // If the class contains static fields, a static constructor must be provided that initializes
        // those fields when the class is loaded.

        private static int field;

        public static int Property
        {
            get { return field; }
            set { field = value; }
        }

        static NotStaticClass()
        {
            Console.WriteLine("Static constructor - NotStaticClass()");
            field = 1;
        }

        // Static methods can be overloaded.
        public static void Method()
        {
            Console.WriteLine("Static method, non-static NotStaticClass");
        }
        public static void Method(int s)
        {
            Console.WriteLine("Overloaded static method, non-static NotStaticClass" + s);
        }

        public void NotStaticMethod()
        {
            Console.WriteLine(field);
        }
    }
}
