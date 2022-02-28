using System;

namespace Dynamic
{
    class MyClass
    {
        dynamic field;

        public MyClass(dynamic arg)
        {
            field = arg;
        }

        public dynamic MyAutoProperty { get; set; }
        
        public dynamic Field
        {
            get { return field; }
            set { field = value; }
        }

        public dynamic Method(dynamic arg)
        {
            return arg;
        }

        dynamic[] array = new dynamic[3];

        public dynamic this[dynamic index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
    class Program
    {
        static void Main()
        {
            dynamic my = new MyClass("Hello");

            Console.WriteLine(my.Field);

            string variable = my.Method("World");

            Console.WriteLine(variable);

            my[0] = "Zero";
            my[1] = "One";
            my[2] = "Two";

            for(dynamic i = 0; i < 3; i++)
            {
                Console.WriteLine(my[i]);
            }
        }
    }
}
