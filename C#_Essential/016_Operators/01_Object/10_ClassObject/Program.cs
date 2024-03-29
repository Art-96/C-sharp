﻿using System;

namespace ClassObject
{
    class MyBaseClass
    {
        public static string CompanyName = "Microsoft";
        public int age;
        public string name;
    }
    class MyDerivedClass : MyBaseClass
    {
        static void Main()
        {
            MyDerivedClass original = new MyDerivedClass();
            original.age = 42;
            original.name = "Alex";

            Console.WriteLine(original.age + " " + original.name + " " + MyDerivedClass.CompanyName);

            MyDerivedClass clone = original.MemberwiseClone() as MyDerivedClass;
            Console.WriteLine(clone.age + " " + clone.name + " " + MyDerivedClass.CompanyName + "\n");

            clone.age = 23;
            clone.name = "Konstantin";
            MyBaseClass.CompanyName = "CyberBionic Systematics";

            Console.WriteLine(original.age + " " + original.name + " " + MyDerivedClass.CompanyName);
            Console.WriteLine(clone.age + " " + clone.name + " " + MyDerivedClass.CompanyName);
        }
    }
}
