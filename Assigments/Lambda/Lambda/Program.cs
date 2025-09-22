using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // New list of employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, firstName = "Joe", lastName = "Doe" },
                new Employee() { Id = 2, firstName = "Joe", lastName = "Smith" },
                new Employee() { Id = 3, firstName = "Sam", lastName = "Brown" },
                new Employee() { Id = 4, firstName = "Sara", lastName = "Davis" },
                new Employee() { Id = 5, firstName = "Mike", lastName = "Wilson" },
                new Employee() { Id = 6, firstName = "Emily", lastName = "Johnson" },
                new Employee() { Id = 7, firstName = "David", lastName = "Lee" },
                new Employee() { Id = 8, firstName = "Anna", lastName = "Garcia" },
                new Employee() { Id = 9, firstName = "Chris", lastName = "Martinez" },
                new Employee() { Id = 10, firstName = "Olivia", lastName = "Harris" },
            };

            // Foreach loop to find all employees with the first name "Joe"
            foreach (Employee emp in employees)
            {
                if (emp.firstName == "Joe")
                {
                    Console.WriteLine($"ID: {emp.Id}, Name: {emp.firstName} {emp.lastName}");
                }
            }

            // Lambda expression to find all employees with the first name "Joe"
            List<Employee> joeList = employees.Where(x => x.firstName == "Joe").ToList();

            // Print the list of employees named "Joe"
            Console.WriteLine("\nEmployees named Joe (using Lambda):");
            foreach (Employee emp in joeList) // Print each employee in the joeList
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.firstName} {emp.lastName}");
            }

            // Lambda expression to find all employees with an ID greater than 5
            List<Employee> idGreaterThanFive = employees.Where(x => x.Id > 5).ToList();
            // Print the list of employees with ID greater than 5
            Console.WriteLine("\nEmployees with ID greater than 5 (using Lambda):");
            foreach (Employee emp in idGreaterThanFive) // Print each employee with ID greater than 5
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.firstName} {emp.lastName}");
            }
        }
    }
}