using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            string card = string.Format(Deck.Cards.First().ToString() + "\n"); // Stores the card that was dealt in a string variable to be displayed in the console.
            Console.WriteLine(card);

            using (StreamWriter file = new StreamWriter(@"C:\Users\victo\Repos\C-Sharp-Projects\TwentyOne\log.txt", true)) // SteamWriter is used to write text to a file. The "true" parameter indicates that we want to append to the file if it already exists.
            {   
                file.WriteLine(DateTime.Now); // Logs the current date and time to the file.
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0); // Removes the top card from the dealer's deck so it can't be dealt again.
        }
    }
}