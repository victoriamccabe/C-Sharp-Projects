using System;

class Program
{
    static void Main()
    {
        // Assignment 1:
        // Takes an input from the user, multiplies it by 50, then prints the result to the console.
        // Using long because the result can be very large (larger than 10,000,000).

        Console.WriteLine("I will multiply your number by 50 and print the result to the console.\nPlease provide a number:");
        long assignment1 = Convert.ToInt64(Console.ReadLine()); // Convert user input to long
        long product = 50L * assignment1; // multiply by 50
        Console.WriteLine("The result is: " + product);

        // Assignment 2:
        // Takes an input from the user, adds 25 to it, then prints the result.

        Console.WriteLine("\nNow, enter a number and I will add 25 to it:");
        long assignment2 = Convert.ToInt64(Console.ReadLine()); // Convert user input to long
        long sum = assignment2 + 25; // Add 25
        Console.WriteLine("The result is: " + sum);

        // Assignment 3:
        // Takes an input from the user, divides it by 12.5, then prints the result.
        // Division result may not be a whole number, so we use double.

        Console.WriteLine("\nNow, enter a number and I will divide it by 12.5:");
        double assignment3 = Convert.ToDouble(Console.ReadLine()); // Convert user input to double
        double quotient = assignment3 / 12.5; // Divide by 12.5
        Console.WriteLine("The result is: " + quotient);

        // Assignment 4:
        // Takes an input from the user, checks if it is greater than 50, then prints true or false.

        Console.WriteLine("\nNow, enter a number and I will check if it is greater than 50:");
        long assignment4 = Convert.ToInt64(Console.ReadLine()); // Convert user input to long
        bool isGreaterThan50 = assignment4 > 50; // Check if greater than 50
        Console.WriteLine("Is the number greater than 50? " + isGreaterThan50);

        // Assignment 5:
        // Takes an input from the user, divides it by 7, then prints the remainder.

        Console.WriteLine("\nFinally, enter a number and I will divide it by 7 and show the remainder:");
        long assignment5 = Convert.ToInt64(Console.ReadLine()); // Convert user input to long
        long remainder = assignment5 % 7; // Find remainder
        Console.WriteLine("The remainder is: " + remainder);

        Console.ReadLine(); // Keep the console window open
    }
}
