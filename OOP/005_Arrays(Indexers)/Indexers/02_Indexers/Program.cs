using System;

namespace Indexers
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();

            myClass[0] = "string 1";
            myClass[1] = "string 2";
            myClass[2] = "string 3";
            myClass[3] = "string 4";
            myClass[4] = "string 5";
            myClass[5] = "string 6";


            Console.WriteLine(myClass[0]);
            Console.WriteLine(myClass[1]);
            Console.WriteLine(myClass[2]);
            Console.WriteLine(myClass[3]);
            Console.WriteLine(myClass[4]);
            Console.WriteLine(myClass[5]);


            MyClass my = new MyClass();

            for (int i = 0; i < 6; i++)
            {
                my[i] = string.Format("string {0}", i);
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(my[i]);
            }


            // Delay.
            Console.ReadKey();
        }
    }
}
