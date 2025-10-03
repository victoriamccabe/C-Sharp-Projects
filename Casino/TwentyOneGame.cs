using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    public class TwentyOneGame : Game // Inherits from the abstract Game class
    {
        public TwentyOneDealer Dealer { get; set; }

        // Constructor to initialize the Players list
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            // Create and shuffle a new deck
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>(); // Initialize the player's hand to an empty list 
                player.Stay = false; // Set the player's Stay property to false
            }
            Dealer.Hand = new List<Card>(); // Initialize the dealer's hand to an empty list so we don't carry over cards from previous rounds
            Dealer.Stay = false; // Set the dealer's Stay property to false the reason is because we want the dealer to be able to play again in the next round
            Dealer.Deck = new Deck(); // Create a new deck of cards for the dealer
            Dealer.Deck.Shuffle(); // Shuffle the dealer's deck of cards
            Console.WriteLine("Place your bet!");

            // Prompt each player to place a bet
            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet); // Attempt to place the bet. If the player doesn't have enough money, successfullyBet will be false
                if (!successfullyBet) // Read as "if successfullyBet is NOT true"
                {
                    return; // Exit the Play method if the bet was not successful
                }

                Bets[player] = bet; // Store the player's bet in the Bets dictionary because dictionary keys need to be unique and we can have multiple players
            }

            // Deal two cards to each player and the dealer
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                // Loop through each player
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name); // Display the player's name
                    Dealer.Deal(player.Hand); // Deal a card to the player's hand
                    if (i == 1) // If this is the second card being dealt
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand); // Check if the player has a blackjack
                        if (blackJack) // If the player has a blackjack
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]); // Announce the blackjack and the winnings
                            player.Balance += Convert.ToInt32((Bets[player]) * 1.5 + Bets[player]); // Update the player's balance with the winnings
                            Bets.Remove(player); // Remove the player from the Bets dictionary since they have already won
                            return; // Exit the Play method since the round is over for this player
                        }
                    }
                }
                Console.Write("Dealer: "); // Display the dealer's name
                Dealer.Deal(Dealer.Hand); // Deal a card to the dealer's hand
                if (i == 1) // If this is the second card being dealt to the dealer
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand); // Check if the dealer has a blackjack
                    if (blackJack) // If the dealer has a blackjack
                    {
                        Console.WriteLine("Dealer has Blackjack! Everyone loses!"); // Announce the dealer's blackjack
                        foreach (KeyValuePair<Player, int> entry in Bets) // Loop through each entry in the Bets dictionary
                        {
                            Dealer.Balance += entry.Value; // Update the dealer's balance with the player's bet amount. It is a Lambda expression. It's the same as Dealer.Balance = Dealer.Balance + entry.Value;
                        }
                        return; // Exit the Play method since the round is over
                    }
                }
            }
            // Loop through each player to allow them to hit or stay
            foreach (Player player in Players)
            {
                while (!player.Stay) // Loop while the player has not chosen to stay
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand) // Loop through each card in the player's hand
                    {
                        Console.Write("{0} ", card.ToString()); // Display the card
                    }
                    Console.WriteLine("\n\nHit or Stay?"); // Prompt the player to hit or stay
                    string answer = Console.ReadLine().ToLower(); // Read and convert the answer to lowercase
                    if (answer == "stay") // If the player chooses to stay
                    {
                        player.Stay = true; // Set the player's Stay property to true
                        break; // Exit the while loop
                    }
                    else if (answer == "hit") // If the player chooses to hit
                    {
                        Dealer.Deal(player.Hand); // Deal a card to the player's hand
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand); // Check if the player has busted
                    if (busted) // If the player has busted
                    {
                        Dealer.Balance += Bets[player]; // Update the dealer's balance with the player's bet amount. It is a Lambda expression. It's the same as Dealer.Balance = Dealer.Balance + Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your new balance is {2}.", player.Name, Bets[player], player.Balance); // Announce the bust and the loss
                        Console.WriteLine("Do you want to play again?"); // Prompt the player to play again)
                        answer = Console.ReadLine().ToLower(); // Read and convert the answer to lowercase
                        if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
                        {
                            player.isActivelyPlaying = true; // Set the player's active status to true
                            return; // Exit the Play method to start a new round
                        }
                        else
                        {
                            player.isActivelyPlaying = false; // Set the player's active status to false
                            return; // Exit the Play method to end the game for this player
                        }
                    }
                }
            }

            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); // Check if the dealer has busted
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand); // Determine if the dealer should stay
            while (!Dealer.Stay && !Dealer.isBusted) // Loop while the dealer has not chosen to stay and has not busted
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand); // Deal a card to the dealer's hand
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); // Check if the dealer has busted
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand); // Determine if the dealer should stay
            }
            if (Dealer.Stay) // If the dealer has chosen to stay
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (!Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted!");
                foreach (KeyValuePair<Player, int> entry in Bets) // Loop through each entry in the Bets dictionary
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value); // Announce the player's win and the amount won
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2); // Update the player's balance with the winnings. It's a Lambda expression. It's the same as "entry.Key.Balance = entry.Key.Balance + (entry.Value * 2);"
                    Dealer.Balance -= entry.Value; // Subtract the player's bet amount from the dealer's balance
                }
            }
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand); // Compare the player's hand to the dealer's hand. "bool?" means it can be true, false, or null
                if (playerWon == null) // If it's a tie
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player]; // Return the player's bet amount to their balance. It's a Lambda expression. It's the same as "player.Balance = player.Balance + Bets[player];"
                }
                else if (playerWon == true) // If the player won
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]); // Announce the player's win and the amount won
                    player.Balance += (Bets[player] * 2); // Update the player's balance with the winnings
                    Dealer.Balance -= Bets[player]; // Subtract the player's bet amount from the dealer's balance
                }
                else // If the dealer won
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]); // Announce the dealer's win and the amount won
                    Dealer.Balance += Bets[player]; // Update the dealer's balance with the player's bet amount
                }
                Console.WriteLine("Play again?"); // Prompt the players to play again
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
                {
                    player.isActivelyPlaying = true; // Set the player's active status to true
                }
                else
                {
                    player.isActivelyPlaying = false; // Set the player's active status to false
                }
            }
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
    
}
