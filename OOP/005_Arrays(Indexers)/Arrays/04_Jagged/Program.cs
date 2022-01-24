using System;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[][] jagged = new int[3][];

            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 1, 2, 3, 4, 5 };
            jagged[2] = new int[] { 1, 2, 3 };

            // The outer loop iterates through all nested arrays.
            for (int i = 0; i < jagged.Length; ++i)
            {
                // The inner loop accesses each element of the nested array.
                for (int j = 0; j < jagged[i].Length; ++j)
                {
                    Console.Write("{0} ", jagged[i][j]);
                }
                Console.Write("\n");
            }


            // Delay.
            Console.ReadKey();
        }
    }
}
