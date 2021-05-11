using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C format: {0:C}", 99.9);
            Console.WriteLine("F format: {0:##}", 99.935);
            Console.WriteLine("N format: {0:N}", 99999);
            Console.WriteLine("X format: {0:X}", 255);
            Console.WriteLine("D format: {0:D}", 0xFF);
            Console.WriteLine("E format: {0:E}", 9999);
            Console.WriteLine("G format: {0:G}", 99.9);
            Console.WriteLine("P format: {0:F}", 99.9);


            Console.ReadKey();
        }
    }
}
