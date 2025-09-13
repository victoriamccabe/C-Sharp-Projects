using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Ask the user to enter the first number
            Console.WriteLine("I will perform a addition operation for you!\nPlease enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to enter the second number (optional!)
            Console.WriteLine("Enter the second number or press enter to skip:");
            string input2 = Console.ReadLine();

            int result;

            // Check if the user entered a second number
            if (string.IsNullOrWhiteSpace(input2))
            {
                // If nothing entered, call DoMath with only one parameter
                result = mathOps.DoMath(num1);
            }
            else
            {
                // Convert the second input to integer and call DoMath with both parameters
                int num2 = Convert.ToInt32(input2);
                result = mathOps.DoMath(num1, num2);
            }

            // Show the result
            Console.WriteLine($"Result of the operation: {result}");

         
            Console.ReadLine();
        }
    }
}
