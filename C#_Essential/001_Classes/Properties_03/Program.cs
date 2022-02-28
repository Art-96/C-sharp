using System;

namespace Properties_03
{
    class MyClass
    {
        private string field = null;

        public string Field
        {
            set
            {
                if (value == "Goodbye")
                {
                    Console.WriteLine("You entered an invalid value. Try again.");
                }
                else
                {
                    field = value;
                }
            }
            get
            {
                if (field == null)
                    return "There is no data in the field \"field\".";
                else if (field == "hello world")
                    return field.ToUpper() + "!";
                else
                    return field;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            instance.Field = "Goodbye";
            Console.WriteLine(instance.Field);

            Console.WriteLine(new string('-', 50));

            instance.Field = "hello world";
            Console.WriteLine(instance.Field);

            // Delay.
            Console.ReadKey();
        }
    }
}
