using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player<T>
    {
        // Constructor to initialize a new player with a name and starting balance
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>(); // Initialize the Hand list to an empty list
            Balance = beginningBalance; // Set the player's starting balance
            Name = name; // Set the player's name
        }
        public List<Card> Hand { get; set; }

        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }


        //    public static Game operator +(Game game, Player player)
        //    {
        //        game.Players.Add(player);
        //        return game;
        //    }


        //    public static Game operator- (Game game, Player player)
        //    {
        //        game.Players.Remove(player);
        //        return game;
        //    }

        //} 
    }
}
 