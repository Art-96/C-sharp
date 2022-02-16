using System;

namespace ClassObject
{
    class MyClassA : Object { }

    class MyClassB : object { }

    class Program
    {
        static void Main()
        {
            MyClassA instanceA = new MyClassA();
            MyClassB instanceB = new MyClassB();
        }
    }
}
