using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {

            // Program title
            Console.WriteLine("Car Insurance Approval");

            // Questions
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Answer with \"True\" or \"False\"");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            // Check eligibility
            bool isQualified = (age > 15) && (dui == false) && (tickets <= 3);

            // Display result
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);

            Console.ReadLine();
        }
    }
}