using System;

namespace GenericsConstraints
{
    // The type argument must have a public parameterless constructor.
    // When used with other constraints, the new() constraint must be set last.

    class MyClass<T> where T : new()
    {
        public T instance = new T();

        public void GetValues()
        {
            Console.WriteLine(instance.ToString());
        }
    }

    class TestClass
    {
        public int MyIntProperty { get; set; }
        public string MyStringProperty { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", MyIntProperty, MyStringProperty);
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass<TestClass> foo = new MyClass<TestClass>();
            foo.instance.MyIntProperty = 1;
            foo.instance.MyStringProperty = "Hello World";
            foo.GetValues();
        }
    }
}
