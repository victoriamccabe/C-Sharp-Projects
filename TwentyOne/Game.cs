using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>(); // Private list to hold players in the game. It's initialized to an empty list.
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>(); // Private dictionary to hold players and their corresponding bets. It's initialized to an empty dictionary.
        public List<Player> Players { get { return _players; } set { _players = value; } } // Public property to access and modify the list of players
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } } // Public property to access and modify the dictionary of bets
        public abstract void Play(); // Abstract means that Every class that ineherits from Game must implement this method

        public virtual void ListPlayers() // It doesn't return anything, just lists players to the console
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}

