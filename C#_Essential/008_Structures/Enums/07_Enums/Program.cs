using System;

namespace Enums
{
    class Program
    {
        static void Main()
        {
            // We place the elements of the enumeration in the array.
            Array array = Enum.GetValues(typeof(EnumType));

            // We get information about the number of elements in the array.
            Console.WriteLine("This enum contains {0} members \n", array.Length);

            // Displaying all elements of an enumeration
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine("Constant name: {0}, meaning {0:D}", array.GetValue(i));
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
