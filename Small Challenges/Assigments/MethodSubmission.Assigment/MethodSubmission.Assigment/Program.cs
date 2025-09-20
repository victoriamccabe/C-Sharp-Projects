using System;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the MathOperations class so we can use its methods
            MathOperations mathOps = new MathOperations();

            int number = 0; // Stores the valid number, start with 0 so it's initialized

            // This will track if the input is valid
            bool isValid = false;

            // Keep asking the user until they give us a real number.
            while (!isValid)
            {
                Console.WriteLine("Enter a number to perform math operations on:");

                // User input
                string userInput = Console.ReadLine();

                // Try to convert the input to an integer. If it works, "isValid" becomes true, and we exit the loop. If it fails, we print an error message and ask again
                if (int.TryParse(userInput, out number))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("That is not a valid number. Please try again.\n");
                }
            }

            // Call the AddTen method and display the result
            int result1 = mathOps.AddTen(number);
            Console.WriteLine("Your number plus 10 is: " + result1);

            // Call the MultiplyByTwo method and display the result
            int result2 = mathOps.MultiplyByTwo(number);
            Console.WriteLine("Your number multiplied by 2 is: " + result2);

            // Call the SubtractFive method and display the result
            int result3 = mathOps.SubtractFive(number);
            Console.WriteLine("Your number minus 5 is: " + result3);

            Console.ReadLine();
        }
    }
}
