using System;

// DateTime represents a point in time, while TimeSpan represents an interval of time.

namespace WorkDateTime
{
    class Program
    {
        static void Main()
        {
            DateTime newYearDate = new DateTime(2023, 1, 1);
            DateTime today = DateTime.Now;

            TimeSpan left = newYearDate - today;
            Console.WriteLine("Until the new year left " + left.Days + " days");
            Console.WriteLine("Until the new year left " + left.TotalHours + " hours");

            // Creating a New Date and Time
            DateTime newDate = new DateTime(2018, 12, 05, 23, 11, 11);

            Console.WriteLine(newDate);
            Console.WriteLine(newDate.TimeOfDay);

            // Converts the given string representation of a date and time to its equivalent
            Console.WriteLine(DateTime.Parse("3/12/2018"));

            Console.WriteLine(DateTime.Parse("05 march 2018")); // Write the month in the local language of the OS.

            // Delay.
            Console.ReadKey();
        }
    }
}
