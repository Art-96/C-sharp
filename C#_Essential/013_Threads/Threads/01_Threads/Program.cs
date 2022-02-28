using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        // The method to be executed on a separate thread.
        static void WriteSecond()
        {
            while (true)
            {
                Console.WriteLine(new string('-', 10) + "Secondary");
            }
        }

        static void Main()
        {
            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            thread.Start();

            while (true)
            {
                Console.WriteLine("Primary");
            }
        }
    }
}
