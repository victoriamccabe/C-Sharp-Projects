using System;

using System;

namespace MathOperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Interger input
            Console.WriteLine("Enter an integer:");
            int userInt = Convert.ToInt32(Console.ReadLine());
            int result1 = mathOps.DoMath(userInt); // Call the integer method
            Console.WriteLine($"Result of integer method: {result1}");

            // Decimal input
            Console.WriteLine("\nEnter a decimal:");
            decimal userDecimal = Convert.ToDecimal(Console.ReadLine());
            int result2 = mathOps.DoMath(userDecimal);
            Console.WriteLine($"Result of decimal method: {result2}");

            // String input
            Console.WriteLine("\nEnter a number as a string:");
            string userString = Console.ReadLine(); // Read input as string
            int result3 = mathOps.DoMath(userString); // Call the string method
            Console.WriteLine($"Result of string method: {result3}");

            Console.ReadLine();
        }
    }
}