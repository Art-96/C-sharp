using System;

namespace Events
{
    public delegate void EventDelegate();

    interface IInterface
    {
        event EventDelegate MyEvent;
        void InvokeEvent();
    }

    public class BaseClass : IInterface
    {
        public virtual event EventDelegate MyEvent = null;

        public virtual void InvokeEvent()
        {
            MyEvent.Invoke();
        }
    }

    public class DerivedClass : BaseClass
    {
        public override event EventDelegate MyEvent = null;

        public override void InvokeEvent()
        {
            MyEvent.Invoke();
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
