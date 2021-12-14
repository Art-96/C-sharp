using System;

// Auto-Implemented properties.

// Automatically implemented properties are a more concise form of properties, it makes sense to use them,
// when in accessor methods (get и set) no additional logic required.
// When creating auto-implemented properties, the compiler will create a private, anonymous fallback field,
// which will be accessible through the get and set methods of the property.

namespace AutoProperties
{
    class Program
    {
        public class Auther
        {
            // Auto-implemented properties.
            public string Name { get; set; }
            public string Book { get; set; }
        }

        static void Main(string[] args)
        {
            Auther auther1 = new Auther()
            {
                Name = "Jeffrey Richter",   // Initializer block.
                Book = "CLR via C#"
            };

            Auther auther2 = new Auther  //()
            {
                Name = "Steve McConnell",
                Book = "Code Complete"
            };

            Console.WriteLine("Name: {0}, Book: {1}", auther1.Name, auther1.Book);
            Console.WriteLine("Name: {0}, Book: {1}", auther2.Name, auther2.Book);

            // Delay
            Console.ReadKey();
        }
    }
}
