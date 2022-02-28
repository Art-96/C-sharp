using System;

namespace StaticMembers
{
    class NotStaticClass
    {
        private int Id;
        public static int field;

        public NotStaticClass(int id)
        {
            this.Id = id;
        }

        public void Method()
        {
            Console.WriteLine("Instance{0}.field = {1}", Id, field);
        }

        public static void StaticMethod()
        {
            // Static methods cannot access non-static fields.
            //Console.WriteLine("Instance.Id = {0}", Id);

            Console.WriteLine("Static methods cannot access non-static fields.");
        }
    }
}
