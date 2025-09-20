using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    // Collection of Card objects
    public class Deck
    {

        public Deck()
        {
            Cards = new List<Card>(); // Initialize the Cards list to an empty list

            for (int i = 0; i < 13; i++) // Loop through all 13 faces (0 to 12)
            {
                for (int j = 0; j < 4; j++) // Loop through all 4 suits (0 to 3)
                {
                    Card card = new Card();
                    card.Face = (Face)i; // Cast the integer i to the Face enum
                    card.Suit = (Suit)j; // Cast the integer j to the Suit enum
                    Cards.Add(card); // Add the newly created card to the Cards list

                }
            }
        }

        public List<Card> Cards { get; set; }

        // Class method to shuffle the deck of cards
        public void Shuffle(int times = 1)
        {
            
            // Shuffle the deck the specified number of times
            for (int i = 0; i < times; i++) // Loop 'times' times until i is no longer less than 'times' ++
            {
                // Create a temporary empty list to store the shuffled cards
                List<Card> TempList = new List<Card>();

                // Create a Random object to generate random numbers
                Random random = new Random();

                // While there are still cards in the original deck
                while (Cards.Count > 0)
                {
                    // Pick a random index from the deck
                    int randomIndex = random.Next(0, Cards.Count);

                    // Take the card at that random index and add it to the TempList
                    TempList.Add(Cards[randomIndex]);

                    // Remove that card from the original deck so it doesn’t get picked again
                    Cards.RemoveAt(randomIndex);
                }

                // Replace the deck’s original Cards list with our shuffled TempList
                Cards = TempList;

            }
        }
    }
}
