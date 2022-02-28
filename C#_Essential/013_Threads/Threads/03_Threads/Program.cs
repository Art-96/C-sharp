using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void WriteSecond()
        {
            // Thread.CurrentThread - returns a reference to the current thread instance.
            Thread thread = Thread.CurrentThread;

            // Give the stream a name.
            thread.Name = "Secondary";

            Console.WriteLine("Thread ID {0}: {1}", thread.Name, thread.GetHashCode());

            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(new string(' ', 15) + thread.Name + " " + counter);
                Thread.Sleep(1000);
            }
        }

        static void Main()
        {
            Thread primaryThread = Thread.CurrentThread;

            primaryThread.Name = "Primary";

            Console.WriteLine("Thread ID {0}: {1}", primaryThread.Name, primaryThread.GetHashCode());

            Thread secondaryThread = new Thread(WriteSecond);
            secondaryThread.Start();

            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(primaryThread.Name + " " + counter);
                Thread.Sleep(1500);
            }
        }
    }
}
