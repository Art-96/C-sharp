using System;

namespace Operators
{
    public struct Point
    {
        private int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // The operator keyword can only be used together with the static keyword!

        // Overloading the + operator.
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", this.x, this.y);
        }
    }
    class Program
    {
        static void Main()
        {
            Point point1 = new Point(1, 1);
            Point point2 = new Point(2, 2);

            Point point3 = point1 + point2;

            Console.WriteLine("point3 = {0}", point3);
        }
    }
}
