using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player
    {
        // Constructor to initialize a new player with a name and starting balance
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>(); // Initialize the Hand list to an empty list
            Balance = beginningBalance; // Set the player's starting balance
            Name = name; // Set the player's name
        }
        private List<Card> _hand = new List<Card>(); // Private list to hold the player's hand of cards. It's initialized to an empty list.
        public List<Card> Hand { get { return _hand; } set { _hand = value; } } // Public property to access and modify the player's hand

        public int Balance { get; set; } // Property to store the player's balance
        public string Name { get; set; } // Property to store the player's name
        public bool isActivelyPlaying { get; set; } // Property to indicate if the player is actively playing
        public bool Stay { get; set; } // Property to indicate if the player has chosen to stay

        // Method to place a bet
        public bool Bet(int amount)
        {
            // Check if the player has enough balance to place the bet
            if (Balance - amount < 0) // If the bet would make the balance negative
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount; // It's the same as "Balance = Balance - amount". Subtract the bet amount from the player's balance
                return true;
            }
        }

        // Method to display the player's hand
        public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }

        // Method to remove a player from the game
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }

    }
}

 