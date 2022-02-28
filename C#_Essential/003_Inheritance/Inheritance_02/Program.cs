using System;

// Casting to base type.

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();

            instance.field1 = 1;
            instance.field2 = 2;
            instance.field3 = 3;
            instance.field4 = 4;
            instance.field5 = 5;

            // Casting an instance of the DerivedClass class to the base type BaseClass.
            BaseClass newinstance = (BaseClass)instance; // Upcast

            Console.WriteLine(newinstance.field1);
            Console.WriteLine(newinstance.field2);
            Console.WriteLine(newinstance.field3);

            // Not available.
            //Console.WriteLine(newInstance.field4);
            //Console.WriteLine(newInstance.field5);


            // Examination.
            Console.WriteLine("instance Id    {0}", instance.GetHashCode());
            Console.WriteLine("newinstance Id {0}", newinstance.GetHashCode());

        }
    }
}
