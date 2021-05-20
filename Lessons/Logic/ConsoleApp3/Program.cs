using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort secretKey = 0x0088;
            char character = 'A';

            Console.WriteLine("Original symbol: {0}, its code in the code table: {1:X}", character, (byte)character);
            Console.WriteLine("Character size: {0} = {1} bit", character, sizeof(char) * 8);

            character = (char)(character ^ secretKey);
            Console.WriteLine("Encrypted symbol: {0}, its code in the code table: {1:X}", character, (byte)character);

            character = (char)(character ^ secretKey);
            Console.WriteLine("Decoded symbol: {0}, its code in the code table: {1:X}", character, (byte)character);
        }
    }
}
