﻿using System;
using System.Threading;

namespace CriticalSection
{
    class MyClass
    {
        object block = new object();

        public void Method()
        {
            int hash = Thread.CurrentThread.GetHashCode();

            Monitor.Enter(block);

            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine("Поток # {0}: шаг {1}", hash, counter);
                Thread.Sleep(100);
            }
            Console.WriteLine(new string('-', 20));

            Monitor.Exit(block);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(80, 40);

            MyClass instance = new MyClass();

            for (int i = 0; i < 3; i++)
            {
                new Thread(instance.Method).Start();
            }
        }
    }
}
