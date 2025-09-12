using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        // The constructor method for the Card class 
        public Card() { 
            Suit = "Spades";
            Face = "Two";
        }
        // Properties of the Card class
        public string Suit { get; set; }
        public string Face { get; set; } 

    }
}
