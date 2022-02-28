using System;

// The params keyword allows you to define a method parameter that takes a variable number of arguments.
// There must be only one parameter with the params keyword, and it must be the last one in the list of method parameters.

namespace Arrays
{
    class Program
    {
        static void ShowArray(string name, params int[] array)
        {
            Console.Write(name);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }

        static void Main()
        {
            ShowArray("Numbers: ", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            // Delay.
            Console.ReadKey();
        }
    }
}
