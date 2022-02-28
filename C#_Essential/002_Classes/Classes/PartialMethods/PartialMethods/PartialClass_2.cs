using System;

namespace Classes
{
    // Second part of the class.
    partial class PartialClass
    {
        // Definition particle method
        partial void PartialMethod()
        {
            Console.WriteLine("Partial method called - PartialMethod()");
        }

        // Calling a partial method through a wrapper method.
        public void CallPartialMethod()
        {
            PartialMethod();

            // When calling an unimplemented partial method, the compiler will ignore it
            // and there will be no runlevel error.
            MyMethod();
        }

        #region Implementation of partial methods in other parts of the class is optional!

        //partial void MyMethod()
        //{
        //    Console.WriteLine("Implementing Partial Methods in Other Parts of the PartialClass - optional!"); ;
        //}

        #endregion
    }
}
