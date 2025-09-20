# Optional Parameter Math App

## Overview
This console application demonstrates the use of **optional parameters** in C#.  
The program asks the user for two numbers, allowing the second number to be optional, performs a math operation (addition), and prints the result.

## Features
1. Asks the user for a **first number**.  
2. Asks the user for a **second number**, which is optional.  
   - The user may press Enter to skip the second number.  
3. Performs a math operation using a method with an **optional parameter**.  
   - If the second number is provided, it adds both numbers.  
   - If the second number is skipped, it adds the first number to the default value (0).  
4. Prints the result to the console.  
5. Fully commented code for beginners to understand the logic.

## Notes
- The app uses "Convert.ToInt32()" to safely convert user input to integers.  
- The method "DoMath" has two parameters, with the second being optional ("num2 = 0").  
- Invalid inputs (non-numeric values) will throw an error.  

## Example Run

<img width="483" height="134" alt="image" src="https://github.com/user-attachments/assets/24f36867-03ee-42e1-86f4-34c9d41275b0" />



