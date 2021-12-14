using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The constructor can call another constructor in the same object using the THIS keyword.

namespace Constructors_03
{
    class Point
    {
        // Fields.
        private int x, y;
        private string name;

        // Properties.
        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }

        // Constructors
        // Using this keyword in the constructor with one parameter from the 45rd string,
        // leads to call this designer.
        public Point(int x, int y)
        {
            Console.WriteLine("Constructor with two parameters.");
            this.x = x;
            this.y = y;
        }

        // Using this keyword in the constructor leads to a constructor call with two parameters from the 36th line.
        public Point(string name)
            : this(100, 200)
        {
            Console.WriteLine("Constructor with one parameter.");
            this.name = name;
        }
    }
}
