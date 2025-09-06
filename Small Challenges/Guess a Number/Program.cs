using System;

class Program
{
    static void Main(string[] args)
    {
        // Boolean comparison using a WHILE loop
        Console.WriteLine("Hello, I am going to count to 20");
        Thread.Sleep(1000); // Pause for 1000 milliseconds 
        //Initialize a counter variable
        int counter = 0;

        // The loop will count until the counter reaches 20

        while (counter <=20)
        {
            Console.WriteLine($"Counter: {counter}");
            counter++; // Increment the counter by 1
            Thread.Sleep(50); // Pause for 50 milliseconds (0.05 seconds)
        }

        Console.WriteLine(); // Print an empty line for spacing

        // Boolean comparison using DO WHILE loop

        // Create a new random number generator instance
        Random random = new Random();

        // Generate a random number between 0 and 20
        int secretNumber = random.Next(0, 20);

        // Max attempts
        const int maxAttempts = 3;

        // Boolean to track if the user guessed the number
        bool guessedCorrectly = false;


        Console.WriteLine("My mind got stuck on a particular number. \n Try to guess which number is. You have 3 attemps. \n Ready?\n Guess a number:");

        // Beginning of guessing loop
        do
        {

        }
        
    }
}
