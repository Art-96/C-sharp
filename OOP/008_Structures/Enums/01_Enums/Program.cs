using System;

// An enumeration is a set of named constants that store numeric values.
// By default, the data type of enumeration constants is int.
// You can use any C# integer data type (byte, sbyte, short, ushort, int, uint, long, ulong)
// Cannot use any C# system integer data type (Byte, SByte, Int16, UInt16, Int32, UInt32, Int64, UInt64)
// All enumerations in C# derive from a single Base class System.Enum

namespace Enums
{
    enum EnumType : byte
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine(EnumType.One);
            Console.WriteLine((byte)EnumType.One);

            EnumType digit = EnumType.Zero;
            Console.WriteLine(digit);
            Console.WriteLine((byte)digit);

            Console.WriteLine(new string('-', 10));

            for (EnumType number = EnumType.Zero; number <= EnumType.Three; number++)
            {
                Console.WriteLine(number);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
