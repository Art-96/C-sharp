using System;

// Classes. Properties with one access method.

namespace Properties_04
{
    class Constants
    {
        private double pi = 3.14D;
        private double e = 2.71D;

        // WriteOnly Property
        public double Pi
        {
            set { pi = value; }
        }

        // ReadOnly Property
        public double E
        {
            get { return e; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Constants constants = new Constants();

            constants.Pi = 3.14159265D;
            //Console.WriteLine(constants.Pi); // It is unacceptable.

            //constants.E = 3.71D;             // It is unacceptable.
            Console.WriteLine("e = {0}", constants.E);

            // Delay.
            Console.ReadKey();
        }
    }
}
