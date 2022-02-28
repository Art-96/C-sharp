using System;

// Inheritance.

namespace Inheritance
{
    class BaseClass
    {
        // Open field.
        public string publicField = "BaseClass.publicField";

        // Closed field.
        private string privateField = "BaseClass.privateField";

        // Protected field.
        protected string protectedField = "BaseClass.protectedField";

        public void Show()
        {
            Console.WriteLine(privateField);
        }
    }
}
