using System;

namespace Delegates
{
    static class MyClass
    {
        public static void Method()
        {
            Console.WriteLine("The string was output by the method reported with the delegate.");
        }
    }

    public delegate void MyDelegate();

    class Program
    {
        static void Main()
        {
            //MyDelegate myDelegate = new MyDelegate(MyClass.Method);

            MyDelegate myDelegate = MyClass.Method; // Предположение делегата.
            myDelegate();
        }
    }
}
