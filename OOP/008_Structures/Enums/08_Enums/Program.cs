using System;

namespace Enums
{
    class Program
    {
        static void Main()
        {
            EnumType x = EnumType.Five;
            EnumType y = EnumType.One;

            //if (x < y)
            if (EnumType.Five < EnumType.One)
                Console.WriteLine("X = {0} (less than) Y = {1}.", x, y);
            else
                Console.WriteLine("Y = {0} (less than) X = {1}.", y, x);

            // Delay.
            Console.ReadKey();
        }
    }
}
