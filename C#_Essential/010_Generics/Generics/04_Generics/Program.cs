﻿using System;

// Universal Delegate

namespace Generics
{
    delegate R MyDelegate<T, R>(T t);
    class Program
    {
        public static int Add(int i)
        {
            return ++i;
        }

        public static string Concatenation(string s)
        {
            return "Hello " + s + "!";
        }

        static void Main()
        {
            MyDelegate<int, int> myDelegate1 = new MyDelegate<int, int>(Add);
            int i = myDelegate1(1);
            Console.WriteLine(i);

            MyDelegate<string, string> myDelegate2 = new MyDelegate<string, string>(Concatenation);
            string s = myDelegate2("Alex");
            Console.WriteLine(s);
        }
    }
}
