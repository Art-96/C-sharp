using System;

// Inheritance is an object-oriented programming mechanism that allows you to describe a new (derived) class
// based on an existing (base) one,
// the properties and functionality of the base class are then taken over by the new derived class.

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();

            Console.WriteLine(instance.publicField);

            instance.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
