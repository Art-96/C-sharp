using System;

namespace Enums
{
    class Program
    {
        static void Main()
        {
            EnumType digit = EnumType.Ten;

            Type @enum = digit.GetType();
            Console.WriteLine("1. The enumeration {0} consists of elements of the type: ", @enum.Name);

            Type @const = Enum.GetUnderlyingType(@enum);
            Console.WriteLine(@const);

            Console.Write("2. The EnumType enumeration consists of elements of type: ");
            Console.WriteLine(Enum.GetUnderlyingType(typeof(EnumType)));
        }
    }
}
