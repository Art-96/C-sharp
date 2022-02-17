using System;

// Overloading the implicit type conversion operator.

namespace Implicit
{
    struct Digit
    {
        public byte value;

        Digit(byte value)
        {
            this.value = value;
        }

        public static implicit operator Digit(byte argument)
        {
            Digit digit = new Digit(argument);
            return digit;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }

    }
    class Program
    {
        static void Main()
        {
            byte variable = 1;

            Digit digit = variable;
            Console.WriteLine(digit);
        }
    }
}
