using System;

namespace WorkDateTime
{
    class Program
    {
        static void Main()
        {
            // DateTime.Now returns a System.DateTime object that is set to the current date and time of day for this computer
            DateTime now = DateTime.Now;

            Console.WriteLine("Current date and time : {0}", now);
            Console.WriteLine("Year: {0}", now.Year);
            Console.WriteLine("Month: {0}", now.Month);
            Console.WriteLine("Day of the month: {0}", now.Day);

            Console.WriteLine("Current time - {0}:{1}:{2}", now.Hour, now.Minute, now.Second);

            Console.WriteLine("Day of the week : {0}", now.DayOfWeek);
            Console.WriteLine("This is the {0}-th day of the year", now.DayOfYear);

            // We get the date of the current computer and the time value equal to midnight (00:00:00).
            Console.WriteLine(DateTime.Now.Date);

            // Delay
            Console.ReadKey();
        }
    }
}
