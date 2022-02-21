using System;
using System.Collections;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            ArrayList numbers = new ArrayList();

            numbers.Add(1);
            numbers.Add(2);

            // EXPLICITLY specifying the Int32 type of a range variable - i
            var query = from int i in numbers
                        select i * 2;

            foreach(var item in query)
                Console.WriteLine(item);
        }
    }
}
