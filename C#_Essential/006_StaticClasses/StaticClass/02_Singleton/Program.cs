using System;

// design pattern - Singleton.

namespace StaticClass
{
    class Program
    {
        static void Main()
        {
            Singleton instance1 = Singleton.Instance();
            Singleton instance2 = Singleton.Instance();

            if (instance1 == instance2)
            {
                Console.WriteLine("References point to a single instance of an object.");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
