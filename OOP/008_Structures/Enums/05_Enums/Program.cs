using System;

namespace Enums
{
    class Program
    {
        static void Main()
        {
            EnumType digit = EnumType.Ten;

            Console.WriteLine("Number {0}", digit.ToString());

            // Enum.Format() - Allows for more precise formatting by specifying a flag,
            // as well as getting the names of enumeration elements by their numeric values

            // Output in hexadecimal format. Flag "x" - hex (hexadecimal format)
            Console.WriteLine("Hex значение {0}", Enum.Format(typeof(EnumType), EnumType.Ten, "x"));

            // Output in decimal format. Flag "D" - dec (decimal format)
            Console.WriteLine("Dec значение {0}", Enum.Format(typeof(EnumType), digit, "D"));

            // Output in string format. Flag "G" - str (String format)
            Console.WriteLine("Str значение {0}", Enum.Format(typeof(EnumType), 10, "G"));

            // Delay.
            Console.ReadKey();
        }
    }
}
