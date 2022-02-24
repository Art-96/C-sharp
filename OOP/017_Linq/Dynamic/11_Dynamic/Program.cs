using System;

// Inheritance

namespace Dynamic
{
    class Base
    {
        public dynamic field;

        public dynamic Method()
        {
            return this.field;
        }
    }

    class Derived : Base
    {

    }

    class Program
    {
        static void Main()
        {
            dynamic instance = new Derived();

            // Dynamic fields must be initialized before being used.
            instance.field = "Hello";

            Console.WriteLine(instance.Method());
        }
    }
}
