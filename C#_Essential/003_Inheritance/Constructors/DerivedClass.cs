using System;

namespace Inheritance
{
    class DerivedClass : BaseClass
    {
        public int derivedNumber;

        // Default Constructor
        public DerivedClass() { }

        // Custom Constructor
        // The custom constructor of the base class is called, and it is not necessary,
        // assign values to inherited members in the constructor of a derived class.
        public DerivedClass(int number1, int number2) : base(number1)
        {
            this.derivedNumber = number2;
        }
    }
}
