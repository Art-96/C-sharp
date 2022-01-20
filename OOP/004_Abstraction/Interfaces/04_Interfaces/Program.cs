using System;

namespace Interfaces
{
    class Program
    {
        static void Main()
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method();
            derivedClass.Method1();
            derivedClass.Method2();

            Console.WriteLine(new string('-', 40));

            BaseClass instance = derivedClass as BaseClass;
            instance.Method();

            Interface1 instance1 = derivedClass as Interface1;
            instance1.Method1();

            Interface2 instance2 = derivedClass as Interface2;
            instance2.Method2();

            //Delay.
            Console.ReadKey();
        }
    }
}
