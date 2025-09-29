using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        // Method that deals a card to a player's hand
        public void Deal(List<Card> Hand)
        {

            Hand.Add(Deck.Cards.First()); // Adds the top card from the dealer's deck to the player's hand. "First()" is a LINQ method that gets the first item in a collection.
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0); // Removes the top card from the dealer's deck so it can't be dealt again.
        }
    }
}