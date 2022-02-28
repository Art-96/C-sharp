using System;

// Dynamic types in delegates

namespace Dynamic
{
    delegate dynamic MyDelegate(dynamic argument);
    class Program
    {
        static dynamic Method(dynamic arg)
        {
            return arg;
        }
        static void Main()
        {
            dynamic myDelegate = new MyDelegate(Method);

            dynamic @string = myDelegate("Hello World!");

            Console.WriteLine(@string);
        }
    }
}
