using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace MathApp
{
    // Class 
    public class MathOperations
    {
        // This method takes a number and adds 10 to it
        public int AddTen(int number)
        {
            // Send the number back to the caller plus 10
            return number + 10;
        }

        // This method takes a number and multiplies it by 2
        public int MultiplyByTwo(int number)
        {
            return number * 2;
        }

        // Takes a number and subtracts 5 from it
        public int SubtractFive(int number)
        {
            return number - 5;
        }
    }
}