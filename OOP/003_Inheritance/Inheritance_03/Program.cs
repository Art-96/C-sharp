using System;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            // UpCast
            BaseClass instanceup = instance;
            instanceup.Method();

            // DownCast
            DerivedClass instancedown = (DerivedClass)instanceup;
            instancedown.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
