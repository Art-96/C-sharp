using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// IMPORTANT:
// If you have created a custom constructor (accepting arguments),
// the default constructor will not be automatically created, it will have to be created explicitly.

namespace Constructors_02
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

        // The constructor designer initializes the default fields.
        //public Point()
        //{
        //    Console.WriteLine("Default Constructor!");
        //}

        // The user constructor initializes the fields with the values ​​of the specified user.
        public Point(int x, int y)
        {
            Console.WriteLine("Custom Constructor!");
            this.x = x;
            this.y = y;
        }
    }
}
