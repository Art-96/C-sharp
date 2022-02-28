using System;

namespace Delegates
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("The string was output by the method reported with the delegate.");
        }
    }

    public delegate void MyDelegate();

    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();

            MyDelegate myDelegate = new MyDelegate(myClass.Method);

            myDelegate.Invoke();

            myDelegate();
        }
    }
}
