using System;

namespace Inheritance
{
    partial class ClassA
    {
        public virtual void Method1() { Console.WriteLine("ClassA.Method1"); }
        public virtual void Method2() { Console.WriteLine("ClassA.Method2"); }
    }

    partial class ClassB : ClassA
    {
        sealed public override void Method1() { Console.WriteLine("ClassB.Method1"); }
        public override void Method2() { Console.WriteLine("ClassB.Method2"); }
    }

    class ClassC : ClassB
    {
        // Attempting to override Method1 results in compiler error: CS0239.
        // public override void Method1() { Console.WriteLine("ClassC.Method1"); }

        // Overriding Method2 is allowed.
        public override void Method2() { Console.WriteLine("ClassC.Method2"); }
    }
    class Program
    {
        static void Main()
        {
            SealedClass instance = new SealedClass();
            instance.x = 100;
            instance.y = 200;
            Console.WriteLine("x = {0}, y = {1}", instance.x, instance.y);


            ClassA instanceA = new ClassA();
            instanceA.Method1();
            instanceA.Method2();

            Console.WriteLine(new string('-', 15));

            ClassB instanceB = new ClassB();
            instanceB.Method1();
            instanceB.Method2();

            Console.WriteLine(new string('-', 15));

            ClassC instanceC = new ClassC();
            instanceC.Method1();
            instanceC.Method2();

            // Delay.
            Console.ReadKey();
        }
    }
}
