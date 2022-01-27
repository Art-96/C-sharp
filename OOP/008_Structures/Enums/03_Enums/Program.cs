using System;

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
            // The variable five of type EnumType can be assigned any value within the range of the base type,
            // values are not limited to named constants.

            EnumType five = (EnumType)5;

            Console.WriteLine(five);

            // Delay.
            Console.ReadKey();
        }
    }
}
