using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    public class TwentyOneDealer : Dealer
    {
        private List<Card> _deck = new List<Card>(); // Private list to hold the dealer's deck of cards. It's initialized to an empty list.
        private List<Card> _hand = new List<Card>(); // Private list to hold the dealer's hand of cards. It's initialized to an empty list.
        public List<Card> Hand {get { return _hand; } set { _hand = value; } } // Public property to access and modify the dealer's hand
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
