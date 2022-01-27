using System;

namespace Boxing
{
    class Program
    {
        interface IInterface
        {
            void Method();
        }

        struct MyStruct : IInterface
        {
            public void Method()
            {
                Console.WriteLine("Method");
            }
        }
        static void Main()
        {
            MyStruct my;
            my.Method();

            IInterface boxed = my;

            boxed.Method();

            MyStruct unBoxed = (MyStruct)boxed;

            // Delay.
            Console.ReadKey();

        }
    }
}
