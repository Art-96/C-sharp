using System;
using System.Threading;

// lock - locks a block of code so that at any given time, only one thread can use this block of code.
// All other threads wait until the current thread finishes its work.

namespace CriticalSection
{
    class MyClass
    {
        object block = new object();

        public void Method()
        {
            int hash = Thread.CurrentThread.GetHashCode();

            lock (block)
            {
                for (int counter = 0; counter < 10; counter++)
                {
                    Console.WriteLine("Flow # {0}: step {1}", hash, counter);
                    Thread.Sleep(100);
                }
                Console.WriteLine(new string('-', 20));
            }
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

            Thread.Sleep(500);
        }
    }
}
