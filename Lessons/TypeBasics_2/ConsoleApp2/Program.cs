using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region implicit type conversion

            byte a = 10;
            int b = 0;
            b = a;

            Console.WriteLine(b);

            int c = 255;
            float d = 0f;
            d = c;

            Console.WriteLine(d);

            #endregion


            #region explicit type conversion

            int e = 256;
            byte f = 0;
            f = (byte)e;

            Console.WriteLine(f);

            float g = 10.5f;
            int h = 0;
            h = (int)g;

            Console.WriteLine(h);

            #endregion


            #region casting constants

            const int i = 255;
            byte j = 0;
            j = i;

            Console.WriteLine(i);

            const float k = 255;
            byte l = 0;
            l = (byte)k;

            Console.WriteLine(l);

            #endregion

            Console.ReadKey();
        }
    }
}
