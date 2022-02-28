using System;

namespace Exceptions
{
    public class ClassWithException
    {
        public void ThrowInner()
        {
            throw new Exception("This is an internal exception!");
        }
        public void CatchInner()
        {
            try
            {
                this.ThrowInner();
            }
            catch(Exception e)
            {
                throw new Exception("This is an external exception!", e);
            }
        }
    }
    class Program
    {
        static void Main()
        {
            ClassWithException instance = new ClassWithException();

            try
            {
                instance.CatchInner();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception caught: {0}", exception.Message);
                Console.WriteLine("Inner Exception : {0}", exception.InnerException.Message);
            }
        }
    }
}
