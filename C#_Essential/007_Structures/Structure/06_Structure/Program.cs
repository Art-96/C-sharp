using System;

namespace Structure
{
    struct MyStruct
    {
        public int field;

        // Custom constructor with parameters.
        public MyStruct(int value)
        {
            this.field = value;
            Console.WriteLine(value);
        }
    }
    class Program
    {
        static void Main()
        {
            // Creating an instance of a structural type without calling a constructor.
            MyStruct instance;

            // You cannot use an uninitialized variable.
            // Since the constructor was not called, the field variable remained uninitialized.
            //Console.WriteLine(instance.field);

            // Delay.
            Console.ReadKey();
        }
    }
}
