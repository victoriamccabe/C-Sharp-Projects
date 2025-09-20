# Division List Tester

## Assignment Instructions

-Create a list of integers. Ask the user for a number to divide each number in the list by. Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.

-Put the loop in a try/catch block. Below and outside of the try/catch block, make the program print a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution. In the catch block, display the error message to the screen. Then try various combinations of user input: valid numbers, zero and a string. Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.

-Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

---

## Overview
The "Division List Tester" is a beginner‑friendly C# console application that demonstrates how to work with lists, loops, user input, and exception handling.  
The program creates a list of integers, asks the user for a number to divide each list item by, and displays the results. It also gracefully handles invalid inputs(such as zero or non‑numeric values) by using a "try/catch/finally" structure and re‑prompting the user until valid input is provided.

## Features
1. **List Creation**
   - Initializes a list of integers with predefined values.
   
2. **User Input Prompt**
   - Asks the user for a divisor to apply to each number in the list.
   
3. **Division Loop**
   - Iterates through the list and divides each number by the user‑entered value.
   - Displays the result of each division in a clear format.
   
4. **Error Handling with try/catch/finally**
   - Catches division by zero errors.
   - Catches invalid input errors (e.g., letters instead of numbers).
   - Displays the error message to the user.
   - Uses a "finally" block to run code after every attempt, regardless of success or failure.
   
5. **Re‑Prompt on Error**
   - If an error occurs, the program asks the user to try again until valid input is entered.
   
6. **Program Continuation**
   - After successful execution, displays a message confirming the program has continued beyond the error handling block.

## How to Run
1. Open the project in a C# IDE (such as Visual Studio) or any console‑capable environment.
2. Build and run the program.
3. Follow the on‑screen instructions:
   - Enter a valid number to see the division results.
   - Try entering "0" to see how division by zero is handled.
   - Try entering a string (e.g., "abc") to see how invalid input is handled.
4. Observe that after each attempt, the program either:
   - Shows the results and ends, or
   - Displays an error message and prompts you again.

## Notes
- This application demonstrates:
  - **Lists** ("List<int>")
  - **Loops** ("foreach")
  - **User input** ("Console.ReadLine")
  - **Type conversion** ("Convert.ToInt32")
  - **Exception handling** ("try/catch/finally")
  - **Input validation** through repeated prompts
- The "finally" block ensures certain code runs after every attempt, making it useful for cleanup or logging.
- Ideal for beginners learning C# fundamentals and safe user input handling.