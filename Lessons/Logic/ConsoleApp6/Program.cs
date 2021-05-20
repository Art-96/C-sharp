using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            byte operand = 0x81;
            Console.WriteLine("Number before shift: {0:X}", operand);

            operand = (byte)(operand << 2);
            Console.WriteLine("Number after left shift: {0:X}", operand);

            operand = (byte)(operand >> 1);
            Console.WriteLine("Number after right shift: {0:X}", operand);

            Console.ReadKey();
        }
    }
}
