using System;

// Anonymous types

namespace Dynamic
{
    class Program
    {
        static void Main()
        {
            dynamic instance = new { Name = "Alex", Age = 18 };

            Console.WriteLine(instance.Name);
            Console.WriteLine(instance.Age);
        }
    }
}
