using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationsApp
{
    // This is our custom class that holds all the overloaded methods
    class MathOperations
    {
        // Method 1 -> Takes an integer, adds 10, and returns the result as an integer
        public int DoMath(int number)
        {
            return number + 10; // Add 10 to the input number
        }

        // Method 2 -> Takes a decimal, multiplies it by 2, and returns the result as an integer
        public int DoMath(decimal number)
        {
            return (int)(number * 2); // Multiply by 2, then cast to integer
        }

        // Method 3 -> Takes a string, converts it to an integer, subtracts 5, and returns the result
        public int DoMath(string numberString)
        {
            // Convert string to integer
            int convertedNumber = Convert.ToInt32(numberString);

            return convertedNumber - 5;
        }
    }
}
