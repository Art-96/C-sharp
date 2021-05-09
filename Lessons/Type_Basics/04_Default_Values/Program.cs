using System;

namespace _04_Default_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a;
            bool b;
            char c;
            string s;

            Console.WriteLine(a);
            // Error: forbidden to use an uninitialized local variable

            a = 2;
            Console.WriteLine(a);
        }
    }
}
