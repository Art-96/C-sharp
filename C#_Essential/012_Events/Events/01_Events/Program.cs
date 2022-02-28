using System;

namespace Events
{
    public delegate void EventDelegate();

    public class MyClass
    {
        public event EventDelegate myEvent = null;

        public void InvokeEvent()
        {
            myEvent.Invoke();
        }
    }
    class Program
    {
        public static void Handler1()
        {
            Console.WriteLine("Event handler 1");
        }

        public static void Handler2()
        {
            Console.WriteLine("Event handler 2");
        }

        static void Main()
        {
            MyClass instance = new MyClass();

            // Attaching event handlers. (Event subscription)
            instance.myEvent += new EventDelegate(Handler1);
            instance.myEvent += Handler2;

            instance.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            // Detach Handler2().
            instance.myEvent -= new EventDelegate(Handler2);

            instance.InvokeEvent();
        }
    }
}
