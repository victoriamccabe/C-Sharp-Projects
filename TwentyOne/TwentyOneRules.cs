using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules
    {
        // This dictionary maps each card face to its corresponding value in the game of Twenty-One (Blackjack)
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {   
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };

        // Method to calculate all possible hand values considering the flexible value of Aces
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace); // Count the number of Aces in the hand
            int[] result = new int[aceCount == 0 ? 1 : aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]); // Calculate the base value of the hand without considering Aces
            result[0] = value; // The first possible value is the base value
            if (result.Length == 1)
            {
                return result;
            }
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10); // Each Ace can contribute an additional 10 points (11 instead of 1). Same as value = value + (i * 10);
                result[i] = value; // Store the new possible hand value
            }
            return result;
        }

        // Method to check if a hand is a blackjack (exactly 21 with two cards)
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand); // Get all possible hand values
            int value = possibleValues.Max(); // Get the maximum possible hand value
            // Check if the maximum hand value is exactly 21
            if (value == 21)
            {
                return true; // Return true if the hand value is exactly 21
            }
            else
            {
                return false; // Return false otherwise
            }
        }

        // Method to determine if a hand is busted (exceeds 21)
        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min(); // Get the minimum possible hand value
            // Check if the minimum hand value exceeds 21
            if (value > 21)
            {
                return true; // Return true if the hand value exceeds 21 (busted)
            }
            else
            {
                return false; // Return false otherwise
            }
        }

        // Method to determine if the dealer should stay (stand) based on their hand value
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand); // Get all possible hand values
            foreach (int value in possibleHandValues) // Loop through each possible hand value
            {
                if (value > 16 && value < 22) // Check if the value is between 17 and 21 (inclusive)
                {
                    return true; // Dealer should stay
                }
            }
            return false; // Dealer should not stay
        }

        // Method to compare the hands of the player and dealer to determine the winner
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand) // Returns true if player wins, false if dealer wins, null if tie
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand); // Get all possible hand values for the player
            int[] dealerResults = GetAllPossibleHandValues(DealerHand); // Get all possible hand values for the dealer

            int playerScore = playerResults.Where(x => x < 22).Max(); // Get the highest valid hand value for the player (<= 21)
            int dealerScore = dealerResults.Where(x => x < 22).Max(); // Get the highest valid hand value for the dealer (<= 21)

            if (playerScore > dealerScore) // If the player's score is higher than the dealer's score
            {
                return true; // Player wins
            }
            else if (playerScore < dealerScore) // If the player's score is lower than the dealer's score
            {
                return false; // Dealer wins
            }
            else
            {
                return null; // It's a tie
            }
        }
}}
