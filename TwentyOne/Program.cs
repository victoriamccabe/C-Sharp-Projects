using System;
using System.Collections.Generic; // Lets us use Lists, Dictionaries, etc.
using System.Linq;                // Useful for queries 
using System.Threading.Tasks;     // Used for async tasks 
using System.Text;                // Useful for string handling 
using System.IO;                  // Used for file input/output 

// ----------------------------------------------------------------
// THIS CODE IS FULLY COMMENTED FOR LEARNING PURPOSES
// ----------------------------------------------------------------

// A namespace is like a container for related classes
namespace TwentyOne 
{
    class Program 
    {
        // The entry point of the program
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's stat by telling me your name.");
            string playerName = Console.ReadLine(); // Read the player's name from console input
            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine()); // Read and convert the player's bank amount
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower(); // Read and convert the answer to lowercase

            // Check if the player wants to play
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank); // Create a new Player object and initialize it with name and bank
                Game game = new TwentyOneGame(); // Create a new instance of the TwentyOneGame class
                game += player; // Adding player to the game using overloaded + operator
                player.isActivelyPlaying = true; // Set the player's active status to true

                // Loop while the player is active and has money
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play(); // Start the game

                }
                game -= player; // Remove player from the game using overloaded - operator
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }
    }
}