using System;

namespace ClassObject
{
    class Program
    {
        static void Main()
        {
            Object instance1 = new Object();
            Object instance2 = new Object();

            Console.WriteLine(instance1.Equals(instance2));

            instance1 = instance2;

            Console.WriteLine(instance1.Equals(instance2));
        }
    }
}
