﻿using System;

namespace NullableTypes
{
    class Program
    {
        static void Main()
        {
            Nullable<int> a = 1;

            if (a.HasValue == true)
            {
                Console.WriteLine("a is {0}.", a.Value);
            }

            int? b = 1;

            if (b.HasValue == true)
            {
                Console.WriteLine("b is {0}.", b.Value);
            }

            // An implicitly typed local variable cannot be Nullable.
            // var? c = null;  
        }
    }
}
