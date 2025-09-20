using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // WHILE loop
  

        Console.WriteLine("I am going to count to 20");
        Thread.Sleep(1000); // Wait for 1 second before starting

        int counter = 0; // Start the counter at 0

        // The loop runs while the counter is less than or equal to 20
        while (counter <= 20)
        {
            Console.WriteLine($"{counter}"); // Print the current counter value
            counter = counter + 1; // Increase the counter by 1
            Thread.Sleep(50); // Small pause so the output is easier to follow
        }

        Console.WriteLine(); // Print an empty line for spacing


        // DO-WHILE loop

        // Random number generator
        Random random = new Random(); 
        int secretNumber = random.Next(0, 20); // Pick a number between 0 and 20
        int attempts = 0; // Keep track of how many tries the user made
        bool guessedCorrectly = false; // Check if the user guessed right

        Console.WriteLine("I picked a number between 0 and 20.\nYou have 3 attempts to guess it!");


        // The guessing loop will always run at least once
        do
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine(); // Get user input

            int guess; // Variable for the user’s guess
            if (int.TryParse(input, out guess)) // Check if input is a number
            {
                attempts = attempts + 1; // Add one to the attempt counter

                if (guess == secretNumber) // If the guess is correct
                {
                    Console.WriteLine("Correct! You guessed the number!");
                    guessedCorrectly = true; // Mark as correct guess
                }
                else
                {
                    Console.WriteLine("Wrong guess, try again!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

        } while (!guessedCorrectly && attempts < 3); // Continue while not correct and attempts left

        // After the loop ends, check the result
        if (!guessedCorrectly)
        {
            Console.WriteLine($"Sorry, you ran out of attempts.\nThe secret number was: {secretNumber}");
        }

        Console.WriteLine("Game over. Thanks for playing!");
    }
}
