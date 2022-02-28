using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterIEnumerable
{
    class Element
    {
        private string name;
        private int field1;
        private int field2;

        public Element(string s, int a, int b)
        {
            this.name = s;
            this.field1 = a;
            this.field2 = b;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Field1
        {
            get { return this.field1; }
            set { this.field1 = value; }
        }

        public int Field2
        {
            get { return this.field2; }
            set { this.field2 = value; }
        }
    }
}
