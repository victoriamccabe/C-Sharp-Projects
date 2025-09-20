using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        //public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); // Abstract means that Every class that ineherits from Game must implement this method

        //public virtual void ListPlayers() // It doesn't return anything, just lists players to the console
        //{
        //    foreach (Player player in Players)
        //    {
        //        Console.WriteLine(player.Name);
        //    }
        //}
    }
}

