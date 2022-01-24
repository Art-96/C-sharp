using System;

namespace Indexers
{
    class BaseClass
    {
        private string[] baseArray = null;

        public BaseClass()
        {
            baseArray = new string[3];
            baseArray[0] = "Ноль";
            baseArray[1] = "Один";
            baseArray[2] = "Два";
        }

        public virtual string this[int index]
        {
            get { return baseArray[index]; }
        }
    }
}
