using Abstract.Assigment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{
    // In the Main method, create an instance of the Employee class, set the firstName and lastName properties, and call the SayName method to display the employee's name.
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // Create an instance of Employee
            employee.firstName = "Sample"; // Set first name
            employee.lastName = "Student"; // Set last name
            employee.SayName(); // Call SayName method to display the name
            Console.ReadLine();
        }
    }
}