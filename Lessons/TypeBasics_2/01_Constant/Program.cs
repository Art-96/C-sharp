using System;

namespace _01_Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.141;

            Console.WriteLine(pi);

            // trying to pass a new value results in an error
            // pi = 2.71828;
        }
    }
}
