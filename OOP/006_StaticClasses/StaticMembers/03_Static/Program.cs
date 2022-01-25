using System;

namespace StaticMembers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(NotStaticClass.Property);

            //Delay.
            Console.ReadKey();
        }
    }
}
