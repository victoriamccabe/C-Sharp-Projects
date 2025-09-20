using System;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // User input for the first number.
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Input for the second number
            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Call the method normally
            Console.WriteLine("Calling method with normal parameters:");
            mathOps.DisplayNumbers(num1, num2);

            Console.WriteLine(); // Empty line 

            // Call the method using named parameters
            Console.WriteLine("Calling method with named parameters:");
            // Demonstrates that parameters can be specified by name
            mathOps.DisplayNumbers(secondNumber: num2, firstNumber: num1);


            Console.ReadLine();
        }
    }
}