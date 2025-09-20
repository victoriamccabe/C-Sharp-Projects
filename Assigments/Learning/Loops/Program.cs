using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to guess a number
            Console.WriteLine("Guess a number");

            // Read the user's input and convert it to an integer
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the initial guess is correct (12) and set the boolean accordingly
            bool isGuessed = number == 12;

            // Start a do-while loop that continues until the correct number is guessed
            do
            {
                // Evaluate the user's guess using a switch statement
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again!");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine()); // Ask for a new guess
                        break;

                    case 29:
                        Console.WriteLine("You guessed 29. Try again!");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine()); // Ask for a new guess
                        break;

                    case 55:
                        Console.WriteLine("You guessed 55. Try again!");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine()); // Ask for a new guess
                        break;

                    case 12:
                        Console.WriteLine("You guessed 12. That is correct!");
                        isGuessed = true; // Correct guess, exit the loop
                        break;

                    default:
                        // Handle all other incorrect guesses
                        Console.WriteLine("You are wrong");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine()); // Ask for a new guess
                        break;
                }
            }

            // Continue looping while the correct number has not been guessed
            while (!isGuessed);

            // Wait for user input before closing the console window
            Console.Read();
        }
    }
}
