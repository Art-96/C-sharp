using System;

// readonly - read-only fields.

namespace Classes
{
    class Program
    {
        // Read-only field (set by constructor only)!
        public readonly string field = "Hello0";

        // Constructor.
        public Program()
        {
            field = "Read-only field";

            field += "!";
        }
        static void Main()
        {
            Program program = new Program();

            Console.WriteLine(program.field);

            // Compilation error.
            // program.field = "An attempt was made to write to a read-only field.";

            // Delay.
            Console.ReadKey();
        }
    }
}
