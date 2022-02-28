using System;
using System.Collections;

namespace Exceptions
{
    class MyClass
    {
        public void Method()
        {
            Exception exception = new Exception("My exception");

            exception.HelpLink = "http://MyCompany.com/ErrorService";
            exception.Data.Add("Cause of exception: ", "Text exception");
            exception.Data.Add("Exception time: ", DateTime.Now);

            throw exception;
        }
    }
    class Program
    {
        static void Main()
        {
            try
            {
                MyClass instance = new MyClass();
                instance.Method();
            }
            catch(Exception e)
            {
                Console.WriteLine("Member name:               {0}", e.TargetSite);
                Console.WriteLine("Class Determining Member:  {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Type of member:            {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message:                   {0}", e.Message);
                Console.WriteLine("Source:                    {0}", e.Source);
                Console.WriteLine("Help Link:                 {0}", e.HelpLink);
                Console.WriteLine("Stack:                     {0}", e.StackTrace);

                foreach(DictionaryEntry de in e.Data)
                {
                    Console.WriteLine("{0} : {1}", de.Key, de.Value);
                }
            }
        }
    }
}
