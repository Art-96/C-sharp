using System;

namespace Indexers
{
    class MyClass
    {
        private string[] array = new string[5];

        public string this[int index]
        {
            get
            {
                if (index > 0 && index < array.Length)
                    return array[index];
                else
                    return "An attempt was made to access outside of the array.";
            }
            set
            {
                if (index > 0 && index < array.Length)
                    array[index] = value;
                else
                    Console.WriteLine("An attempt was made to write outside the array.");
            }
        }
    }
}
