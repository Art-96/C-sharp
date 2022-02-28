using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayList_ListGen
{
    class Program
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();

            // Boxing.
            arrayList.Add(1);
            arrayList.Add((object)2);

            // Unboxing
            int i1 = (int)arrayList[0];

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine((int)arrayList[i]);
            }

            Console.WriteLine(new string('-', 5));

            List<int> list = new List<int>();

            list.Add(3);
            list.Add(5);

            int i3 = list[0];

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
