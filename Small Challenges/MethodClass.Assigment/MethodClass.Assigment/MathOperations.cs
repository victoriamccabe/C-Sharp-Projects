using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    // This class contains a void method demonstrating math operations and displaying values
    class MathOperations
    {
        // Void method that takes two integers as parameters & performs a math operation on the first number and displays the second number.
        public void DisplayNumbers(int firstNumber, int secondNumber)
        {
            // Example math operation-> multiply the first number by 2
            int result = firstNumber * 2;

            // Display the result of the math operation on the first number
            Console.WriteLine($"First number after operation: {result}");

            // Display the second number as received
            Console.WriteLine($"Second number as the same: {secondNumber}");
        }
    }
}