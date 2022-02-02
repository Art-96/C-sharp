using System;

namespace NullableTypes
{
    class Program
    {
        static void Main()
        {
            int? a = null;
            int? b = a + 4; // null
            int? c = a * 5; // null

            Console.WriteLine("->{0}<-", a);
        }
    }
}
