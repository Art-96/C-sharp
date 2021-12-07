using System;

// Classes. (Using properties to access private fields.)

// Property - an interface for accessing an object field.
// Properties in C # - fields with a boolean block containing the get and set keywords
// and are a surrogate for replacement of accessor methods for the field.
// When accessing a property, a specific method is called, which performs certain operations on an object.

namespace Properties_02
{
    class MyClass
    {
        private string field = null;
        
        public string Field
        {
            set  // void SetField(string value)   -    mutator  (setter)
            {
                field = value;
            }
            get // string GetField()              -    accessor (getter)
            {
                return field;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            instance.Field = "Hello World!";

            Console.WriteLine(instance.Field);

            // Delay.
            Console.ReadKey();
        }
    }
}
