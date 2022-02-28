using System;
using System.Collections;

namespace Yield
{
    class Program
    {
        static void Main()
        {
            foreach(string element in UserCollection.Power())
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(new string('-', 12));

            //-----------------------------------------------------------------------------------------------

            IEnumerable enumerable = UserCollection.Power();

            IEnumerator enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext())
            {
                String element = enumerator.Current as String;

                Console.WriteLine(element);
            }
        }
    }
}
