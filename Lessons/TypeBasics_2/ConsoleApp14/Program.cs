﻿using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Hello ";
            string word2 = "World!";
            string phrase = word1 + word2;

            Console.WriteLine(phrase);

            Console.WriteLine("Hello " + "World!");

            Console.ReadKey();
        }
    }
}
