using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public void ListPlayers() // It doesn't return anything, just lists players to the console
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
