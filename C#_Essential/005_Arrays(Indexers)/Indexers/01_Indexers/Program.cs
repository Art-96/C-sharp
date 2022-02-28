using System;

namespace Indexers
{
    class MyClass
    {
        private int[] array = new int[5];

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();

            myClass[0] = 1;
            myClass[1] = 2;
            myClass[2] = 3;
            myClass[3] = 4;
            myClass[4] = 5;

            Console.WriteLine(myClass[0]);
            Console.WriteLine(myClass[1]);
            Console.WriteLine(myClass[2]);
            Console.WriteLine(myClass[3]);
            Console.WriteLine(myClass[4]);

            // Delay.
            Console.ReadKey();
        }
    }
}
