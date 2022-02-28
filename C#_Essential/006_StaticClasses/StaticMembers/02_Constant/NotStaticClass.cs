using System;

namespace StaticMembers
{
    class NotStaticClass
    {
        // Constants cannot be static.
        // public static const float e = 2.71828182845904523536f;

        // A field cannot be declared as static const, a const field by its behavior is already static.
        // A const field refers to a type, not to instances of the type.
        // Therefore, const fields can be accessed using the same ClassName.MemberName notation,
        // as in used for static fields.

        public const float e = 2.71828182845904523536f;
    }
}
