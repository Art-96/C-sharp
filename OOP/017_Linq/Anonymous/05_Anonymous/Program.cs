﻿using System;

namespace Anonymous
{
    delegate void MyDelegate(string @string);
    class Program
    {
        static void Main()
        {
            var instance = new
            {
                MyDel = new MyDelegate ((string @string) => Console.WriteLine(@string))
            };

            instance.MyDel("Hello World");
        }
    }
}
