using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte port = 0xF0;
            byte mask = 0x02;
            Console.WriteLine("port = {0:x}", port);

            port = (byte)(port | mask);
            Console.WriteLine("port = {0:x}", port);

            mask = 0xFD;

            port = (byte)(port & mask);
            Console.WriteLine("port = {0:x}", port);

            Console.ReadKey();
        }
    }
}
