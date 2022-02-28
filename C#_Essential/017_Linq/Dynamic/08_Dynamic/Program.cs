using System;

// Dynamic Types in Parameterized Delegates

namespace Dynamic
{
    delegate R MyDelegate<T, R>(T arg);
    class Program
    {
        static dynamic Method(dynamic arg)
        {
            return arg;
        }

        static void Main()
        {
            dynamic myDelegat = new MyDelegate<dynamic, dynamic>(Method);

            dynamic @string = myDelegat("Hello World!");

            Console.WriteLine(@string);
        }
    }
}
