using System;

namespace Generics
{
    class Animal { }
    class Cat : Animal { }

    class Program
    {
        delegate void MyDelegate<in T>(T a);

        public static void CatUser(Animal animal)
        {
            Console.WriteLine(animal.GetType().Name);
        }

        static void Main()
        {
            MyDelegate<Animal> delegateAnimal = new MyDelegate<Animal>(CatUser);
            MyDelegate<Cat> delegateCat = delegateAnimal;

            delegateAnimal(new Animal());
            delegateCat(new Cat());

            //delegateCat(new Animal()); // Impossible.
        }
    }
}
