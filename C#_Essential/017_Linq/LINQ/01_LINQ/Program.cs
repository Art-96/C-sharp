using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Salary = 94000,
                    StartDate = DateTime.Parse("1/4/1992")
                },
                new Employee
                {
                    FirstName = "Petr",
                    LastName = "Petrov",
                    Salary = 123000,
                    StartDate = DateTime.Parse("12/3/1985")
                },
                new Employee
                {
                    FirstName = "Andrew",
                    LastName = "Andreev",
                    Salary = 1000000,
                    StartDate = DateTime.Parse("1/12/2005")
                }
            };

            // Query expression.
            var query = from employee in employees
                        where employee.Salary > 100000
                        orderby employee.LastName, employee.FirstName
                        select new
                        {
                            LastName = employee.LastName,
                            FirstName = employee.FirstName
                        };

            Console.WriteLine("Highly paid employees:");

            foreach(var item in query)
            {
                Console.WriteLine("{0} {1}", item.LastName, item.FirstName);
            }
        }
    }
}
