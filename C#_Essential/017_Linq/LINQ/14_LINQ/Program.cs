﻿using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var query = from i in numbers
                        group i by i % 2 into partition
                        where partition.Key == 0
                        select new { Key = partition.Key, Count = partition.Count(), Group = partition };

            foreach (var item in query)
            {
                Console.WriteLine("mod2 == {0}", item.Key);
                Console.WriteLine("Count == {0}", item.Count);

                foreach (var number in item.Group)
                    Console.Write("{0}, ", number);

                Console.WriteLine();
            }
        }
    }
}
