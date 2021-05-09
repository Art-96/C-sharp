using System;

namespace _06_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            char b = '\x0041';
            char c = '\u0041';

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
