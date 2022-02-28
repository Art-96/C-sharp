using System;

namespace StaticMembers
{
    class NotStaticClass
    {
        // static field.
        static int field;

        // Static property.
        public static int Property
        {
            get { return field; }
            set { field = value; }
        }
    }
}
