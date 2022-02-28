using System;

namespace StaticMembers
{
    class Program
    {
        static void Main()
        {
            NotStaticClass instance1 = new NotStaticClass(1);
            NotStaticClass instance2 = new NotStaticClass(2);

            instance1.Method();
            instance2.Method();

            // accessing a static field - field
            NotStaticClass.field = 1;

            instance1.Method();
            instance2.Method();

            NotStaticClass.StaticMethod();

            // Delay.
            Console.ReadKey();
        }
    }
}
