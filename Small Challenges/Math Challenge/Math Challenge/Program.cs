using System;

// Math Challenge: Perform basic arithmetic operations and display the results.
int num1 = 10;
int num2 = 20;

// Addition
int sum = num1 + num2;
Console.WriteLine($"- Addition: The sum of {num1} and {num2} is {sum}");

// Subtraction
int difference = num2 - num1;
Console.WriteLine($"- Substraction: The difference between {num2} and {num1} is {difference}");

// Multiplication
int product = num1 * num2;
Console.WriteLine($"- Multiplication: The product of {num1} and {num2} is {product}");

// Division
int quotient = num2 / num1;
Console.WriteLine($"- Division: The quotient of {num2} divided by {num1} is {quotient}");

// Division with double to show a decimal result
double quotient2 = 10.0 / 5.5;
Console.WriteLine($"- Double: The quotient of 10.0 divided by 5.5 is {quotient2}");

// Remainder showing modulus operation
int remainder = num2 % num1;
Console.WriteLine($"- Remainder: The remainder of {num2} divided by {num1} is {remainder}");

// String concatenation: Combine strings + int to form a sentence.
string Name = "Vicky";
int Age = 30;
Console.WriteLine($"- Sting concatenation: My name is {Name} and I am {Age} years old.");

// Boolean comparison: Check if current temperature is greater than room temperature.
int roomTemperature = 70;
int currentTemperature = 72;
bool isWarm = currentTemperature > roomTemperature;
Console.WriteLine($"- Boolean comparision: It is warm today: {isWarm}");



Console.ReadLine(); // Keep the console window open
