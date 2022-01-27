using System;


namespace Enums
{
    enum EnumType
    {
        Zero,  // = 0 
        One,   // = 1
        one = One,
        Two = 2,
        Three, // = 3
        Four,  // = 4
        Five = 5,
        Six = Nine,
        //Seven,
        Eight = 8, // If you do not specify the value explicitly, then there will be an error on line 13!
        Nine,
        Ten = 10,
        Infinite = 255
    }
}
