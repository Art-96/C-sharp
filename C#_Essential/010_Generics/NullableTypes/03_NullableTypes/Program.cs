﻿using System;

namespace NullableTypes
{
    class Program
    {
        static void Main()
        {
            int? a = null;
            int? b;

            b = a ?? 10;
            Console.WriteLine(b);

            a = 3;
            b = a ?? 10;
            Console.WriteLine(b);
        }
    }
}
