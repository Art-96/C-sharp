using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool operand1 = false, operand2 = false, result = false;

            #region conjunction

            operand1 = true;
            operand2 = false;
            result = operand1 && operand2;

            Console.WriteLine("{0} and {1} = {2}", operand1, operand2, result);

            #endregion

            #region disjunction
            operand1 = true;
            operand2 = false;
            result = operand1 || operand2;

            Console.WriteLine("{0} or {1} = {2}", operand1, operand2, result);
            #endregion

            #region exclusive or
            operand1 = true;
            operand2 = false;
            result = operand1 ^ operand2;

            Console.WriteLine("{0} XOR {1} = {2}", operand1, operand2, result);
            #endregion

            #region negation
            operand1 = true;
            result = !operand1;

            Console.WriteLine("NOT {0} = {1}", operand1, result);
            #endregion

            Console.ReadKey();
        }
    }
}
