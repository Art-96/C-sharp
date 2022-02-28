using System;

// Dynamic types of arguments and return values of methods.

namespace Dynamic
{
    class Program
    {
        static dynamic Method(ref dynamic arg1, out dynamic arg2)
        {
            arg1 = ++arg1;
            arg2 = 2;

            return default(dynamic);
        }
        static void Main()
        {
            dynamic variable1 = 0, variable2;

            Method(ref variable1, out variable2);

            Console.WriteLine(variable1);
            Console.WriteLine(variable2);
        }
    }
}
