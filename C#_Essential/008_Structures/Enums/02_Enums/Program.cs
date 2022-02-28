using System;



namespace Enums
{
    class Program
    {
        // Enum as method argument
        public static void MethodEnum(EnumType e)
        {
            switch (e)
            {
                case EnumType.Zero:
                    Console.WriteLine("Number 0");
                    break;
                case EnumType.Two:
                    Console.WriteLine("Number 2");
                    break;
                case EnumType.Five:
                    Console.WriteLine("Number 5");
                    break;
                case EnumType.Ten:
                    Console.WriteLine("Number 10");
                    break;

                default: break;
            }
        }
        static void Main()
        {
            MethodEnum(EnumType.Five);

            EnumType digit = EnumType.Ten;
            MethodEnum(digit);

            int i = (int)(++digit);
            Console.WriteLine(i);

            Console.WriteLine(digit); // The variable has changed.
            Console.WriteLine((int)EnumType.Ten); // The constant has not changed.

            digit++;
            digit = digit + 5;

            // Not allowed.
            //digit = ++EnumType.One;
            //digit = EnumType.One + EnumType.Two; 

            // Delay.
            Console.ReadKey();
        }
    }
}
