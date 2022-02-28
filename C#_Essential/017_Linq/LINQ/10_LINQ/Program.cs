using System;
using System.Collections.Generic;
using System.Linq;

// let - represents a new local identifier that can be referenced in the rest of the request.

namespace LINQ
{
    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var employees = new List<Employee>
            {
                new Employee {LastName = "Ivanov", FirstName = "Ivan"},
                new Employee {LastName = "Andreev", FirstName = "Andrew"},
                new Employee {LastName = "Petrov", FirstName = "Petr"}
            };

            var query = from emp in employees
                        let fullName = emp.LastName + " " + emp.FirstName
                        orderby fullName descending
                        select fullName;

            foreach (var person in query)
                Console.WriteLine(person);
        }
    }
}
