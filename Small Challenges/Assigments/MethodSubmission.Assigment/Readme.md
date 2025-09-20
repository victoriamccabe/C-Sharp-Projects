# Math Operations App

## Assignment Instructions
This project was created based on the following assignment requests:

1. Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer. The methods should do some math operation on the received parameter. Put this class in a separate .cs file in the application.
2. In the Main() program, ask the user what number they want to do the math operations on.
3. Call each method in turn, passing the user input to the method. Display the returned integer to the screen.
4.Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.


## Features
### MathOperations Class
- "AddTen(int number)": Adds 10 to the number.  
- "MultiplyByTwo(int number)": Multiplies the number by 2.  
- "SubtractFive(int number)": Subtracts 5 from the number.  

### Main Program
- Asks the user to enter a number.  
- Validates the input using "int.TryParse" so only real numbers are accepted.  
- Calls each math method one by one.  
- Displays the result of each operation with clear output messages.  

## Example Usage
When running the program, a sample interaction might look like this:

"Enter a number to perform math operations on:"  
12  
"Your number plus 10 is: 22"  
"Your number multiplied by 2 is: 24"  
"Your number minus 5 is: 7"  

