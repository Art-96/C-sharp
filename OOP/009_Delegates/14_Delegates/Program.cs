using System;

namespace Delegates
{
    delegate void MyDelegate(int argument);

    class Program
    {
        static void Main()
        {
            MyDelegate my = null; // It is mandatory to assign null.

            my = (int i) =>
            {
                i--;
                Console.WriteLine("Begin {0}", i);

                if (i > 0)
                {
                    my(i);
                }

                Console.WriteLine("End {0}", i);
            };

            my(3);
        }
    }
}
