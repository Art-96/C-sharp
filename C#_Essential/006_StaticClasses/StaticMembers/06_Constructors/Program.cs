using System;

namespace StaticMembers
{
    class Program
    {
        static void Main()
        {
            // 1 option. (Only the static constructor is called.)
            NotStaticClass.StaticMethod();

            // 2 option. (Both Constructors are called.)
            //new NotStaticClass().NotStaticMethod();

            // Delay.
            Console.ReadKey();
        }
    }
}
