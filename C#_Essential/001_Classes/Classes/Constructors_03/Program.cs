using System;

namespace Constructors_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point("A");
            Console.WriteLine("{0}.X = {1}, {0}.Y = {2}", point.Name, point.X, point.Y);

            // Delay
            Console.ReadKey();
        }
    }
}
