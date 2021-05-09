using System;

namespace _03_Basic_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            #region integer types

            byte a = 0;
            Byte b = 255;

            sbyte c = -128;
            SByte d = 127;

            ushort e = 0;
            UInt16 f = 65535;

            short g = -32768;
            Int16 h = 32767;

            uint i = 0u;
            UInt32 j = 4294967295U;

            int k = -2147483648;
            Int32 l = 2147483647;

            ulong m = 0ul;
            UInt64 n = 18446744073709551615UL;

            long o = -9223372036854775808L;
            Int64 p = 9223372036854775807L;

            #endregion


            #region real types

            float q = -0.123456789f; // f is required
            Single r = 1.123456789F;

            double s = -0.123456789d;
            Double t = 1.123456789;

            #endregion


            #region decimal type

            decimal u = -0.12345m; // m is required
            Decimal v = 1.1234567M;

            #endregion


            #region logical type

            bool w = true;
            Boolean x = false;

            #endregion


            #region symbolic type

            char y = 'a';
            Char z = 'A';

            #endregion


            #region string type

            string firstString = "hello";
            String secondString = "HELLO";

            #endregion



        }
    }
}
