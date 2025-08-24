# C# Console Program - User Input Assignments

## Overview
This program demonstrates basic input, output, and arithmetic operations in C#. 
It asks the user for input and performs a series of tasks, printing results to the console.

## Features
1. Takes an input from the user, multiplies it by 50, and prints the result.
   - Uses "long" to handle very large inputs (greater than 10,000,000).

2. Takes an input from the user, adds 25, and prints the result.

3. Takes an input from the user, divides it by 12.5, and prints the result.
   - Uses "double" for division to allow decimal results.

4. Takes an input from the user, checks if it is greater than 50, and prints a True/False result.

5. Takes an input from the user, divides it by 7, and prints the remainder using the "%" operator.

## Notes
- The program uses "Convert.ToInt64()" and "Convert.ToDouble()" to safely handle input.
- Invalid inputs (non-numeric values) will throw an error.
