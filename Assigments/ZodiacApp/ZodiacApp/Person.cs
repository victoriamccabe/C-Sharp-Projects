using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZodiacApp
{
    public class Person
    {
        // Properties for the person
        public string Name { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public string ZodiacSign { get; set; }

        // First constructor: takes only name
        public Person(string name)
        {
            Name = name;
        }

        /* Second constructor: takes name, day, and month
            Notice the ": this(name)" -> this is constructor chaining, It calls the first constructor to avoid duplicate code */
        public Person(string name, int day, int month) : this(name)
        {
            Day = day;
            Month = month;

            // Use the helper class to find the zodiac sign
            ZodiacSign = ZodiacHelper.GetZodiacSign(day, month);
        }
    }
}