using System;

/*
 *  Original expression                          Equivalent expression
 *     !A && !B                       =                  !(A || B)
 *     !A && B                        =                  !(A || !B)
 *     A && !B                        =                  !(!A || B)   
 *     A && B                         =                  !(!A || !B)
 *     !A || !B                       =                  !(A && B)
 *     !A || B                        =                  !(A && !B)
 *     A || !B                        =                  !(!A && B) 
 *     A || B                         =                  !(!A && !B)    
 */

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            bool B = false;

            if (!A || !B)
                Console.WriteLine("!A || !B = {0}", !A || !B);
            else
                Console.WriteLine("!A || !B = {0}", !A || !B);

            if (!(A && B))
                Console.WriteLine("!(A && B) = {0}", !(A && B));
            else
                Console.WriteLine("!(A && B) = {0}", !(A && B));

            // Delay.
            Console.ReadKey();
        }
    }
}
