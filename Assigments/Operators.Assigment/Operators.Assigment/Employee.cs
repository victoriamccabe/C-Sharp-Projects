using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.Assigment
{
    public class Employee
    {
        // Create properties for Id, FirstName, and LastName
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload == operator
        // Overload == operator
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null or reference equals, return true
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If either is null, return false
            if (emp1 is null || emp2 is null)
                return false;

            // Compare by Id
            return emp1.Id == emp2.Id;
        }


        // Overload != operator
        public static bool operator != (Employee emp1, Employee emp2)
        {
            return false;
        }
    }
}
