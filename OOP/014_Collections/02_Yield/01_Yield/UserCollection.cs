using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Yield
{
    class UserCollection
    {
        public static IEnumerable Power()
        {
            yield return "Hello World";
        }
    }
}
