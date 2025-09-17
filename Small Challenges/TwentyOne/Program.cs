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
            TwntyOneGame game = new TwntyOneGame(); // Create a new instance of the TwntyOneGame class
            game.Players = new List<string>() { "Alice", "Bob", "Charlie" }; // Initialize the Players list with some names
            game.ListPlayers(); // Call the ListPlayers method to print out the players
            game.Play();
            Console.ReadLine(); // Print a blank line for better readability

            //// Create a new Deck object (we have a Deck class already defined)
            //// The Deck class should have a property called "Cards", which is a list of Card objects
            //Deck deck = new Deck();
            //deck.Shuffle(3); // Shuffle the deck 3 times

            //// Loop through every Card in the deck
            //foreach (Card card in deck.Cards)
            //{
            //    // Print out the card's face and suit to the console
            //    // Example: "Ace of Spades"
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}

            //// Print the total number of cards in the deck (should be 52 if it's a standard deck)
            //Console.WriteLine(deck.Cards.Count);
            

            //// Pause the program so the console window doesn’t close immediately
            //Console.ReadLine();
        }

        //// This method "shuffles" the deck of cards
        //public static Deck Shuffle(Deck deck)
        //{
        //    // Create a temporary empty list to store the shuffled cards
        //    List<Card> TempList = new List<Card>();

        //    // Create a Random object to generate random numbers
        //    Random random = new Random();

        //    // While there are still cards in the original deck
        //    while (deck.Cards.Count > 0)
        //    {
        //        // Pick a random index from the deck
        //        int randomIndex = random.Next(0, deck.Cards.Count);

        //        // Take the card at that random index and add it to the TempList
        //        TempList.Add(deck.Cards[randomIndex]);

        //        // Remove that card from the original deck so it doesn’t get picked again
        //        deck.Cards.RemoveAt(randomIndex);
        //    }

        //    // Replace the deck’s original Cards list with our shuffled TempList
        //    deck.Cards = TempList;

        //    // Return the shuffled deck back to the caller
        //    return deck;
        //}

        //// Overloaded Shuffle method that shuffles the deck multiple times
        //public static Deck Shuffle(Deck deck, int times) 
        //{
        //    // Shuffle the deck the specified number of times
        //    for (int i = 0; i < times; i++) // Loop 'times' times until i is no longer less than 'times' ++
        //    {
        //        deck = Shuffle(deck); // Call the single-shuffle method
        //}
        //    return deck;

        //}

        }

    } 