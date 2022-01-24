using System;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            var array1 = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(array1.GetType());

            var array2 = new[] { 3.1415, 1, 6 };
            Console.WriteLine(array2.GetType());

            // Doesn't compile. (Incompatible types)
            // var array3 = new [] { 1, "string" };

            // Delay.
            Console.ReadKey();
        }
    }
}
