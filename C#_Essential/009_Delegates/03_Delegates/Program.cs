﻿using System;

namespace Delegates
{
    class MyClass
    {
        public string Method(string name)
        {
            return "Hello " + name;
        }
    }

    public delegate string MyDelegate(string name);
    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            MyDelegate myDelegate = new MyDelegate(instance.Method);

            string greeting = myDelegate.Invoke("Jeffrey Richter");
            Console.WriteLine(greeting);

            greeting = myDelegate("Grady Booch");
            Console.WriteLine(greeting);
        }
    }
}
