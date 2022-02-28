using System;

namespace ICloneableWork
{
    class Program
    {
        static void Main()
        {
            Point original = new Point(100, 100);
            Point clone = original.Clone() as Point;

            Console.WriteLine("First check.");

            Console.WriteLine(original);
            Console.WriteLine(clone);

            clone.x = 0;

            Console.WriteLine("Second check after change.");
            Console.WriteLine(original);
            Console.WriteLine(clone);
        }
    }
}
