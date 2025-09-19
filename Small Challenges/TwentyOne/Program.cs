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

            TwentyOneGame game = new TwentyOneGame(); // Create a new instance of the TwentyOneGame class
            game.Players = new List<string>() { "Bob", "Sue", "Joe" }; // Initialize the Players property with a list of player names
            game.ListPlayers(); // Call the ListPlayers method to display the players
            Console.ReadLine();
            //Deck deck = new Deck(); // Create a new instance of the Deck class

            //foreach (Card card in deck.Cards) // Loop through each card in the deck
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit); // Print the face and suit of each card
            //}
            //Console.WriteLine(deck.Cards.Count); // Print the total number of cards in the deck (should be 52)
            //Console.ReadLine(); // Wait for user input before closing the console

        }

    }
}