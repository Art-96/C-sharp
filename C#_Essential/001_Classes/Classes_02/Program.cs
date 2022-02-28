using System;

// Transfer of a class instance as a method argument

namespace Classes_02
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Called method of class MYCLASS");
        }
    }
    
    class MyClass2
    {
        // On line 18, we create a method called CallMethod that takes one argument of type MyClass and returns nothing
        public void CallMethod(MyClass my)
        {
            // In the body of the CallMethod method, on line 21, we call the method named Method of the argument my
            my.Method();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();

            MyClass2 my2 = new MyClass2();

            my2.CallMethod(my);

            // Delay
            Console.ReadKey();
        }
    }
}
