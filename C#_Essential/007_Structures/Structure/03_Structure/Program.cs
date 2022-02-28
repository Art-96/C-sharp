using System;

namespace Structure
{
    struct MyStruct
    {
        public int field;

        // Default constructors cannot be set explicitly.
        //public MyStruct()
        //{
        //}

        // If the structure has a user-defined constructor, then it is required to initialize all fields in it.

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
            MyStruct instance = new MyStruct();

            Console.WriteLine(instance.field);

            // Creation of an instance of a structural type, with a call to a custom constructor.            
            MyStruct instance2 = new MyStruct(1);

            Console.WriteLine(instance2.field);

            // Delay.
            Console.ReadKey();
        }
    }
}
