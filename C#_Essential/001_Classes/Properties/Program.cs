using System;

// Using methods of accessing private fields.

namespace Properties
{
    class MyClass
    {
        private string field = null;

        public void SetField(string value) // mutator  (setter)
        {
            field = value;
        }
        public string GetField() // accessor  (getter)
        {
            return field;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            instance.SetField("Hello World!"); // method-mutator

            string @string = instance.GetField(); // method-accessor

            Console.WriteLine(@string);

            // Delay.
            Console.ReadKey();
        }
    }
}
