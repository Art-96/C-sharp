using System;

// Rule: Override GetHashCode by overriding Equals.

namespace ClassObject
{
    class Point : object
    {
        protected int x, y;

        public Point(int xvalue, int yvalue)
        {
            x = xvalue;
            y = yvalue;
        }

        public override bool Equals(object obj)
        {
            if(obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Point p = (Point)obj;
            return (x == p.x) && (y == p.y);
        }

        public override int GetHashCode()
        {
            return x ^ y;
        }
    }
    class Program
    {
        static void Main()
        {
            Point a = new Point(1, 2);
            Point b = new Point(1, 2);
            Point c = new Point(0, 0);

            Console.WriteLine("a == b : {0}", a.Equals(b));
            Console.WriteLine("a == c : {0}", a.Equals(c));
        }
    }
}
