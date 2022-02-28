using System;

// If you have created a custom constructor (accepting arguments),
// the default constructor will not be automatically created, it will have to be created explicitly.

namespace Constructors_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Apply the constructor designer.
            //Point pointA = new Point();
            //Console.WriteLine("pointA.x = {0}, pointA.y = {1}", pointA.X, pointA.Y);

            Console.WriteLine(new string('-', 30));

            // Apply a constructor with parameters.
            Point pointB = new Point(100, 200);
            Console.WriteLine("pointB.X = {0}, pointB.Y = {1}", pointB.X, pointB.Y);

            // Delay
            Console.ReadKey();
        }
    }
}
