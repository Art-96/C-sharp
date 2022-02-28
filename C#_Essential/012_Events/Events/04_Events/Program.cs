using System;

namespace Events
{
    public delegate void EventDelegate();

    interface IInterface
    {
        event EventDelegate MyEvent;
    }

    public class BaseClass : IInterface
    {
        EventDelegate myEvent = null;

        public virtual event EventDelegate MyEvent
        {
            add { myEvent += value; }
            remove { myEvent -= value; }
        }

        public void InvokeEvent()
        {
            myEvent.Invoke();
        }
    }

    public class DerivedClass : BaseClass
    {
        public override event EventDelegate MyEvent
        {
            add
            {
                base.MyEvent += value;
                Console.WriteLine("An event handler was attached to the base class event - {0}", value.Method.Name);
            }
            remove
            {
                base.MyEvent -= value;
                Console.WriteLine("A handler was detached from the base class event - {0}", value.Method.Name);
            }
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
            DerivedClass instance = new DerivedClass();

            instance.MyEvent += new EventDelegate(Handler1);
            instance.MyEvent += new EventDelegate(Handler2);

            instance.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            instance.MyEvent -= new EventDelegate(Handler2);
            instance.InvokeEvent();
        }
    }
}
