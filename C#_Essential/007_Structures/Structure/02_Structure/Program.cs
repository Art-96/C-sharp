using System;

// If the structure has members that access the field and no user-defined constructor,
// then the default constructor must be called when creating an instance. (Otherwise there will be an error.)

namespace Structure
{
    struct MyStruct
    {
        private int field;

        public int Field
        {
            get { return field; }
            set { field = value; }
        }

        public void Show()
        {
            Console.WriteLine(field);
        }
    }
    class Program
    {
        static void Main()
        {
            // Creation of an instance of a structural type with a call to the default constructor.
            MyStruct instance = new MyStruct();

            instance.Field = 1;

            Console.WriteLine(instance.Field);

            // Delay.
            Console.ReadKey();
        }
    }
}
