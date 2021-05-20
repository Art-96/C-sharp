using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte operand1 = 0, operand2 = 0;

            int result;

            #region conjunction

            operand1 = 0xFF;
            operand2 = 0x01;
            result = operand1 & operand2;

            Console.WriteLine("{0} and {1} = {2}", operand1, operand2, result);

            #endregion


            #region disjunction
            operand1 = 0x01;
            operand2 = 0x02;
            result = operand1 | operand2;

            Console.WriteLine("{0} or {1} = {2}", operand1, operand2, result);
            #endregion

            #region exclusive or
            operand1 = 0x003;
            operand2 = 0x001;
            result = operand1 ^ operand2;

            Console.WriteLine("{0} XOR {1} = {2}", operand1, operand2, result);
            #endregion

            #region negation
            operand1 = 0x01;
            result = ~operand1;

            Console.WriteLine("NOT {0} = {1}", operand1, result);
            #endregion

            #region change the sign of a number
            operand1 = 0x01;
            result = ~operand1;
            result++;

            Console.WriteLine(" ~ {0} + 1 = {1}", operand1, result);
            #endregion

            Console.ReadKey();
        }
    }
}
