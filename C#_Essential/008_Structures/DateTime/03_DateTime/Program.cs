using System;

namespace WorkDateTime
{
    class Program
    {
        static void Main()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("Date month (in words) year : {0:D}", now);
            Console.WriteLine("Date.month.year : {0:d}", now);
            Console.WriteLine("Date month (in words) year time (hh:mm:ss) : {0:F}", now);
            Console.WriteLine("Date month (in words) year time (hh:mm) : {0:f}", now);
            Console.WriteLine("Date.month.year time(hh:mm:cc) : {0:G}", now);
            Console.WriteLine("Date.month.year time(hh:mm) : {0:g}", now);
            Console.WriteLine("Current month and date : {0:M}", now);
            Console.WriteLine("Current month and year : {0:Y}", now);
            Console.WriteLine("Time(hh:mm:cc) : {0:T}", now);
            Console.WriteLine("Time(hh:mm) : {0:t}", now);

            // Delay.
            Console.ReadKey();
        }
    }
}
