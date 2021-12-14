using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Point
    {
        // Fields.
        private int x, y;

        // Properties.
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }

        // Constructor by default, initializes the default fields.
        public Point()
        {
            Console.WriteLine("Constructor by default!");
        }

        // Custom constructor, initializes the fields by the values ​​of the specified user.
        public Point(int x, int y)
        {
            Console.WriteLine("Custom constructor!");
            this.x = x;
            this.y = y;
        }
    }
}
