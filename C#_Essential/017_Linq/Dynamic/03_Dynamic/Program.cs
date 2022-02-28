using System;

// Dynamic data types. (Non-static fields)

namespace Dynamic
{
    class Program
    {
        dynamic field = 1, field2 = "Hello", field3 = true;

        static void Main()
        {
            dynamic instance = new Program();

            Console.WriteLine(instance.field);

            instance.field = "Hello world!";

            Console.WriteLine(instance.field);

            instance.field = DateTime.Now;

            Console.WriteLine(instance.field);
        }
    }
}
