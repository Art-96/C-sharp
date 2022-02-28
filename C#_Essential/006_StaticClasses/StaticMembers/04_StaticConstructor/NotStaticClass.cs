using System;

// Static constructors have the following properties:
// 1. A static constructor has no access modifiers and takes no parameters.
// 2. The static constructor is called automatically to initialize the class before the first instance is created
// or any static members are referenced.
// 3. A static constructor cannot be called directly.
// 4. The user has no control over when a static constructor is executed in a program.
// 5. A typical use for static constructors is when a class uses a log file
// and the constructor is used to add entries to that file.

namespace StaticMembers
{
    class NotStaticClass
    {
        static readonly long readonlyField = 2;

        public static long ReadonlyField
        {
            get { return NotStaticClass.readonlyField; }
        }

        static NotStaticClass()
        {
            readonlyField = 1;
        }
    }
}
