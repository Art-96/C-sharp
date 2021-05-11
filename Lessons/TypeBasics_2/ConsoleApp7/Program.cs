using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            byte variable1 = 0;

            variable1 = (byte)(variable1 + 5);

            variable1 += 5;

            #region assignment operations with

            int variable2 = 0;
            variable2 = variable2 + 5;
            variable2 += 5;

            uint variable3 = 0;
            variable3 = variable3 - 5;
            variable3 -= 5;

            long variable4 = 0;
            variable4 = variable4 * 5;
            variable4 *= 5;

            ulong variable5 = 0;
            variable5 = variable5 / 5;
            variable5 /= 5;

            long variable6 = 0;
            variable6 = variable6 % 5;
            variable6 %= 5;

            #endregion
        }
    }
}
