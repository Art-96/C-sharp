using System;

// Overloading the explicit type conversion operator.

namespace Explicit
{
    struct Digit
    {
        public byte value;

        Digit(byte value)
        {
            this.value = value;
        }

        public static explicit operator Digit(byte argument)
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

            Digit digit = (Digit)variable;

            Console.WriteLine(digit);
        }
    }
}
