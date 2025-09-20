using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.Assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two Employee objects with the same Id, FirstName, and LastName
            Employee emp1 = new Employee { Id = 1, FirstName = "Peter", LastName = "Parker" };
            Employee emp2 = new Employee { Id = 1, FirstName = "Peter", LastName = "Parker" };
            Employee emp3 = new Employee { Id = 2, FirstName = "Mary", LastName = "Jane" };

            // Test the overloaded operators
            Console.WriteLine(emp1 == emp2); // True
            Console.WriteLine(emp1 != emp3); // True
        }
    }
}