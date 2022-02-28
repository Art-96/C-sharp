using System;

// Structures can contain static members.
// Static structures are not allowed.

namespace Structure
{
    struct MyStruct
    {
        public static int Field { get; set; }

        public static void Show()
        {
            Console.WriteLine(Field);
        }
    }

    class Program
    {
        static void Main()
        {
            // Initialization of static fields is optional.
            //MyStruct.Field = 1;

            MyStruct.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
