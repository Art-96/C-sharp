using System;

// self-association

namespace Classes
{
    class MyClass
    {
        MyClass instance;

        public MyClass()  // StackOverflowException
        {
            Console.WriteLine("Constructor MyClass");

            // Self-association, after the first instantiation attempt, leads to cyclic instantiation.

            instance = new MyClass();
        }
    }
    class Program
    {
        static void Main()
        {
            // Attempting to instantiate the MyClass

            MyClass instance = new MyClass();

            // Delay.
            Console.ReadKey();
        }
    }
}
