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
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Jesse";

            game += player;
            game -= player;
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}