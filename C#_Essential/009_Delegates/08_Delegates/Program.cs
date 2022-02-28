using System;

namespace Delegates
{
    public delegate int MyDelegate(int a);
    class Program
    {
        static void Main()
        {
            MyDelegate myDelegate;

            myDelegate = delegate (int a) { return a * 2; }; // Lambda Method

            myDelegate = (x) => { return x * 2; };           // Lambda Operator.

            myDelegate = (x) => x * 2;                       // Lambda Expression.

            int result = myDelegate(4);
            Console.WriteLine(result);
        }
    }
}
