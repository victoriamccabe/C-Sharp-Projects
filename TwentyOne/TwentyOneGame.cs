using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
     public class TwentyOneGame : Game, IWalkAway
    {
        // This method is specific to the TwntyOneGame class
        public override void Play() // Override means we are providing the specific implementation of the Play method for this class
        {
            throw new NotImplementedException(); 
        }

        public override void ListPlayers() // Override the ListPlayers method from the Game class
        {
            Console.WriteLine("21 Players:"); // Print a header specific to 21 players
            base.ListPlayers(); // Call the base class (Game) ListPlayers method to do the actual listing
        }

        public void WalkAway(Player player) // Implementation of the WalkAway method from the IWalkAway interface
        {
            throw new NotImplementedException(); // Placeholder for actual implementation
        }

    }
}
