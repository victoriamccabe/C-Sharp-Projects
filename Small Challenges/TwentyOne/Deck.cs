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
        // Creating a constructor for the Deck class. A constructor is method that is called as soon as an object of the class is instantiated.
        // The constructor method has the same name as the class and does not have a return type.
        public Deck()
        {
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);

            // Easier way to do the same thing as above with a nested foreach loop

            // Refers to the property of the Deck class
            Cards = new List<Card>();
            // Create a list (collection) of the four suits in a deck of cards
            List<string> Suits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };

            // Create a list of the thirteen face values in a deck of cards
            List<string> Faces = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

            // Loop through every "face" value (Two, Three, ..., Ace)
            foreach (string face in Faces)
            {
                // For each face, loop through every "suit" (Clubs, Diamonds, Hearts, Spades)
                foreach (string suit in Suits)
                {
                    // Create a new Card object (this assumes you have a Card class defined)
                    Card card = new Card();

                    // Assign the face value to this card
                    card.Face = face;

                    // Assign the suit to this card
                    card.Suit = suit;

                    // Add the finished card to a collection called "Cards"
                    // (This "Cards" list must already exist somewhere in your program)
                    Cards.Add(card);
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
