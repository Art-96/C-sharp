using System;

// Using the technique of factory methods.

namespace Classes
{
    class Product
    {
        public Product()
        {
            Console.WriteLine("An instance of the Product class has been created");
        }
    }

    class Factory
    {
        public Product FactoryMethod()
        {
            return new Product();
        }
    }
    class Program
    {
        static void Main()
        {
            Factory factory = new Factory();

            Product product = factory.FactoryMethod();

            // Delay.
            Console.ReadKey();
        }
    }
}
