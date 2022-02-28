using System;

namespace Generics
{
    class Animal { }
    class Cat : Animal { }

    class Program
    {
        delegate T MyDelaegate<out T>();

        public static Cat CatCreator()
        {
            return new Cat();
        }

        static void Main()
        {
            MyDelaegate<Cat> delaegateCat = new MyDelaegate<Cat>(CatCreator);
            MyDelaegate<Animal> delaegateAnimal = delaegateCat;

            Animal animal = delaegateAnimal.Invoke();

            Console.WriteLine(animal.GetType().Name);
        }
    }
}
