using System;

namespace Anonymous
{
    class Program
    {
        static void Main()
        {
            // Anonymous types in anonymous types.

            var instance = new { Name = "Alex", Age = 27, Id = new { Number = 123 } };

            Console.WriteLine("Name = {0}, Age = {1}, Id = {2}", instance.Name, instance.Age, instance.Id.Number);
        }
    }
}
