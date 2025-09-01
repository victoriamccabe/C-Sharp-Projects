# C# Console Program - Package Express Shipping Quote  

## Overview  
This program demonstrates input handling, arithmetic calculations, conditional logic, and ternary operators in C#.  
It simulates a **Package Express shipping service** that determines if a package can be shipped based on its weight and size, then calculates a shipping quote.  

## Features  
1. Prints a **welcome message** to the user.  
2. Prompts the user for the package **weight**.  
   - If the weight is **greater than 50**, the program displays:  
     "Package too heavy to be shipped via Package Express. Have a good day." and exits.  
3. Prompts the user for the package **width, height, and length**.  
   - If the total dimensions (width + height + length) are **greater than 50**, the program displays:  
     "Package too big to be shipped via Package Express." and exits.  
4. If the package passes both checks:  
   - Calculates the quote as:  
     (width × height × length × weight) ÷ 100.  
   - Displays the result formatted as a **dollar amount** with two decimal places.  
   - Example:  
     "Your estimated total for shipping this package is: $528.00".  
5. Ends with a polite **thank you message**.  

## Notes  
- The program uses **Convert.ToDecimal()** to safely handle user input for numeric values.  
- **Ternary operators** are used for conditional checks to simplify logic.  
- If the user enters invalid (non-numeric) input, the program will throw an error.  
- The output ensures clear communication of **errors** or **quote results**.  