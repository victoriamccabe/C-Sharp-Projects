using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Assigment
{
    // Create another class called Employee that inherits from Person and implements the SayName method to display the full name of the employee.
    public class Employee : Person // Inherits from Person
    {
        public override string firstName { get; set; } // Override property for first name
        public override string lastName { get; set; } // Override property for last name
        public override void SayName() // Override method to say the name
        {
            Console.WriteLine($"Name: {firstName} {lastName}"); // Display full name
        }
    }
    
    }

