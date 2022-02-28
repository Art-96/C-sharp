using System;

namespace Events
{
    public delegate void EventDelegate();

    public class MyClass
    {
        EventDelegate myEvent = null;

        // The implementation of the add and remove accessors for the event.
        public event EventDelegate MyEvent
        {
            add { myEvent += value; }
            remove { myEvent -= value; }
        }

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
            MyClass myClass = new MyClass();

            myClass.MyEvent += new EventDelegate(Handler1);
            myClass.MyEvent += new EventDelegate(Handler2);

            myClass.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            myClass.MyEvent -= new EventDelegate(Handler2);
            myClass.InvokeEvent();
        }
    }
}
