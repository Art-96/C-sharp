using System;

namespace Classes
{
    //We create a class named MyClass.
    //In the body of the class, create a public field of type string named field and a method named Method.
    class MYClass
    {
        public string field;

        public void Method()
        {
            Console.WriteLine(field);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create an instance of the MyClass class (by strong link).
            // 2. We create an instance of the MyClass class named instance.
            // 3. Let's instantiate the MyClass class.
            // 4. Create a variable named instance of type MyClass and assign it the address of the instance on the heap.
            // (instance - is a reference to an instance of the MyClass class built on the heap)

            MYClass instance = new MYClass();

            // The field field of the instance instance is set to Hello world!

            instance.field = "Hello World!";

            // Display the value of the field 'field' of the instance 'instance'.

            Console.WriteLine(instance.field);

            // Calling a method named Method on an instance.
            instance.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
