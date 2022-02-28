using System;

namespace StaticMembers
{
    class NotStaticClass
    {
        public NotStaticClass()
        {
            Console.WriteLine("Constructor.");
        }

        static NotStaticClass()
        {
            Console.WriteLine("Static Constructor.");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("StaticMethod()");
        }

        public void NotStaticMethod()
        {
            Console.WriteLine("NotStaticMethod()");
        }
    }
}
