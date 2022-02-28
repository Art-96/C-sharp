using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        // A static method that is scheduled to run simultaneously on the main (primary) and secondary threads.
        static void WriteSecond()
        {
            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine("Thread Id {0}, counter = {1}", Thread.CurrentThread.GetHashCode(), counter);
                counter++;
            }
        }

        static void Main()
        {
            Thread thread = new Thread(WriteSecond);
            thread.Start();

            WriteSecond();
        }
    }
}
