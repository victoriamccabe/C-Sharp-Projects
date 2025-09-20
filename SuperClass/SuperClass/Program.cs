using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // initialize an Employee object
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // call the SayName method from the Person class
            employee.SayName();
        }
    }
}
