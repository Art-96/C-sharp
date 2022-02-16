using System;

// The inheritance graph is cloned deeply.

namespace ClassObject
{
    class A { public int a = 1; }

    class B : A { public int b = 2; }

    class C : B { public int c = 3; }

    class X : C { }

    class Program : X
    {
        static void Main()
        {
            Program original = new Program();
            Console.WriteLine("Original : " + original.a + " " + original.b + " " + original.c);

            Program clone = original.MemberwiseClone() as Program;
            Console.WriteLine("Clone : " + clone.a + " " + clone.b + " " + clone.c + "\n");

            clone.a = clone.b = clone.c = 7;

            Console.WriteLine("Original : " + original.a + " " + original.b + " " + original.c);
            Console.WriteLine("Clone : " + clone.a + " " + clone.b + " " + clone.c);
        }
    }
}
