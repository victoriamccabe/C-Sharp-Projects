using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Assigment
{
    // Create an abstract class called Person with two properties: firstName and lastName.
    public abstract class Person
    {
        public abstract string firstName { get; set; } // Abstract property for first name
        public abstract string lastName { get; set; } // Abstract property for last name

        public abstract void SayName(); // Abstract method to say the name

    }
}
