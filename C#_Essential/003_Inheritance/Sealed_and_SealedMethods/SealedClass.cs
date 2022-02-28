using System;

// Sealed classes.

namespace Inheritance
{
    sealed class SealedClass
    {
        public int x;
        public int y;
    }

    // Attempt to inherit from SealedClass results in a compiler error.

    class DerivedClass //: SealedClass   // Error
    {
    }
}
