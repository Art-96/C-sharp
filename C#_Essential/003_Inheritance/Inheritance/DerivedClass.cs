using System;

namespace Inheritance
{
    class DerivedClass : BaseClass
    {
        // Constructor
        public DerivedClass()
        {
            // We change all available fields inherited from the base class.

            publicField = "DerivedClass.publicField";
            protectedField = "DerivedClass.protectedField";
        }
    }
}
