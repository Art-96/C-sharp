using System;

namespace Enums
{
    class Program
    {
        static void Main()
        {
            // We find the enumeration element by the name of the constant.
            object element = Enum.Parse(typeof(EnumType), "Infinite");
            EnumType number = (EnumType)element;

            Console.WriteLine("Constant value {0}: {1}", number, (byte)number);

            // Enum.IsDefined() - Allows you to determine if a character string is an element of an enumeration?
            bool flag = Enum.IsDefined(typeof(EnumType), "one");

            if (flag == true)
            {
                Console.WriteLine("Yes, the enum contains an element with that name.");
            }
            else
            {
                Console.WriteLine("No, the enum does not contain an element with that name.");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
