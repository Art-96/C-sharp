using System;

namespace Delegates
{
    public delegate void MyDelegate();

    class Program
    {
        static void Main()
        {
            // We create an instance of the MyDelegate delegate class and communicate an anonymous method with it.
            MyDelegate myDelegate = delegate { Console.WriteLine("Hello world!"); };

            myDelegate();
        }
    }
}
