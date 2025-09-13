using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterApp
{
    // This class contains methods for math operations
    class MathOperations
    {
        // Method that takes two integers, the second one is optonal (default value = 0)
        public int DoMath(int num1, int num2 = 0)
        {
            // Add the two numbers and return the result
            return num1 + num2;
        }
    }
}