using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void WriteSecond(object argument)
        {
            Console.WriteLine(argument);
            Thread.Sleep(1000);
        }
        static void Main()
        {
            ParameterizedThreadStart writeSecond = new ParameterizedThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            thread.Start("Hello");

            Thread.Sleep(500);
        }
    }
}
