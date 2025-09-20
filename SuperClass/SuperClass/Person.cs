using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClass
{
    public class Person
    {
        // Last name of the person
        public string LastName { get; set; }

        // First name of the person
        public string FirstName { get; set; }

        public void SayName()
        {
                       Console.WriteLine($"My name is {FirstName} {LastName}");
        }
    }
}
