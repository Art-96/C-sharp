using System;

namespace Delegates
{
    public delegate void MyDelegate();
    class Program
    {
        static void Main()
        {
            MyDelegate myDelegate;

            myDelegate = delegate { Console.WriteLine("Hello 1"); };

            myDelegate += () => { Console.WriteLine("Hello 2"); };

            myDelegate += () => Console.WriteLine("Hello 3");

            myDelegate();
        }
    }
}
