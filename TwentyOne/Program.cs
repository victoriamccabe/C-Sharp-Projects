using System;
using System.Collections.Generic; // Lets us use Lists, Dictionaries, etc.
using System.Linq;                // Useful for queries (not used here, but often included)
using System.Threading.Tasks;     // Used for async tasks (not used here)
using System.Text;                // Useful for string handling (not used here)

// ----------------------------------------------------------------
// THIS CODE IS FULLY COMMENTED FOR LEARNING PURPOSES
// ----------------------------------------------------------------

namespace TwentyOne // A namespace is like a container for related classes
{
    class Program // Our main class where execution starts
    {
        static void Main(string[] args) // The entry point of the program
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's stat by telling me your name.");
            string playerName = Console.ReadLine(); // Read the player's name from console input
            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine()); // Read and convert the player's bank amount
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower(); // Read and convert the answer to lowercase
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank); // Create a new Player object and initialize it with name and bank
            }
        }
    }
}