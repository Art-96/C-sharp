using System;

namespace Events
{
    public delegate void EventDelegate();

    public class MyClass
    {
        public event EventDelegate MyEvent = null;

        public void InvokeEvent()
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
            MyClass instance = new MyClass();

            instance.MyEvent += new EventDelegate(Handler1);
            instance.MyEvent += new EventDelegate(Handler2);
            instance.MyEvent += delegate { Console.WriteLine("Анонимный метод 1."); };

            instance.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            instance.MyEvent -= new EventDelegate(Handler2);

            // Unable to unpin a previously attached anonymous method.
            instance.MyEvent -= delegate { Console.WriteLine("Анонимный метод 1."); };

            instance.InvokeEvent();
        }
    }
}
