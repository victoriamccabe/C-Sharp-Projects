using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of integers
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // -----------------------------------------------------------------------------------
        // I added this block to make the program to keep asking until valid input is received
        // -----------------------------------------------------------------------------------

        // Will track if we got valid input and completed the division
        bool success = false;

        // Loop until we get valid input and complete the division
        while (!success)
        {
            // Ask the user for a number to divide each number in the list by
            Console.Write("Enter a number to divide each list item by: ");
            string userInput = Console.ReadLine(); // Read the input as a string

            try
            {
                // Try to convert the user input to an integer
                int divisor = Convert.ToInt32(userInput);

                // Loop through each number in the list
                foreach (int i in numbers)
                {
                    // Perform the division
                    int result = i / divisor;

                    // Display the result to the screen
                    Console.WriteLine($"{i} divided by {divisor} = {result}");
                }

                // If we reach here, everything worked fine
                success = true; // Exit the loop
            }
            catch (Exception ex) // Catch ANY type of exception
            {
                // Display the error message to the screen and ask for input again
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine("Please try again.");
            }

            // This block will always execute, regardless of whether an exception occurred or not
            finally
            {
                Console.WriteLine("Attempt finished.\n");
            }
        }

        // This message will always display after the loop finishes successfully
        Console.WriteLine("Program has emerged from the try/catch/finally block and continued execution.");
        Console.ReadLine();
    }
}