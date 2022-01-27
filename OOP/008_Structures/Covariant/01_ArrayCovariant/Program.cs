using System;

namespace ArrayCovariant
{
    class Program
    {
        public interface IAnimal
        {
            void Voice();
        }

        public struct Dog : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("Voice");
            }
        }
        static void Main()
        {
            Dog[] dogs = { new Dog(), new Dog(), new Dog() };

            //IAnimal[] animal = dogs; // Covariance.
            //dogs = array;  // Contravariance.
            ValueType i = new Int32() as ValueType;

            int[] vector = new int[3] { 1, 2, 3 };
            //object[] array = vector; // Covariance.

            // Delay
            Console.ReadKey();
        }
    }
}
