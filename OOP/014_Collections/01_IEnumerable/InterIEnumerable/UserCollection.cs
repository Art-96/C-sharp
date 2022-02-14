using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterIEnumerable
{
    class UserCollection : IEnumerable, IEnumerator
    {
        public Element[] elementsArray = null;

        public UserCollection()
        {
            elementsArray = new Element[4];
            elementsArray[0] = new Element("A", 1, 10);
            elementsArray[1] = new Element("B", 2, 20);
            elementsArray[2] = new Element("C", 3, 30);
            elementsArray[3] = new Element("D", 4, 40);
        }

        int posicion = -1;

        // ------------------------------------------------------------------------------------------------

        public bool MoveNext()
        {
            if(posicion < elementsArray.Length - 1)
            {
                posicion++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            posicion = -1;
        }


        public object Current
        {
            get { return elementsArray[posicion]; }
        }

        // -------------------------------------------------------------------------------------------------

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
    }
}
