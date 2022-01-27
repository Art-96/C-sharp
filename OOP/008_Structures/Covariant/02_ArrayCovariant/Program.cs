﻿using System;

namespace ArrayCovariant
{
    class Program
    {
        static void Main()
        {
            uint[] array = new uint[3];

            Console.WriteLine("array  {0} {1}", array is uint[], array is int[]);

            object @object = array;

            Console.WriteLine("object {0} {1}", @object is uint[], @object is int[]);

            // Delay.
            Console.ReadKey();
        }
    }
}
