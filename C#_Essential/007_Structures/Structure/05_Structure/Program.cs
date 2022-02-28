using System;

namespace Structure
{
    struct MyStruct
    {
        public int field;

        // A static constructor always executes first.
        static MyStruct()
        {
            Console.WriteLine("Static Constructor");
        }

        public MyStruct(int value)
        {
            Console.WriteLine("Constructor");
            this.field = value;
        }
    }

    class Program
    {
        static void Main()
        {
            MyStruct instance = new MyStruct { field = 0 };

            Console.WriteLine(instance.field);

            // Delay.
            Console.ReadKey();
        }
    }
}
