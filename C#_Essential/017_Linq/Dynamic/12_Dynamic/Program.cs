using System;

namespace Dynamic
{
    class MyClass
    {

    }

    class Program
    {
        static dynamic FactoryMethod()
        {
            return new MyClass();
        }

        static void Main()
        {
            dynamic instance = FactoryMethod() as dynamic;

            if (false)
            {
                instance.Method(7);
                instance.field = instance.Property;
                instance["one"] = instance[2];
                dynamic variable = instance + 3;
                variable = instance(5, 7);
            }
        }
    }
}
