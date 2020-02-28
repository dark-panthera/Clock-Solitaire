using SolitaireExample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireExample.Models
{
    /// <summary>
    /// 
    /// Display the Playing Card
    /// 
    /// </summary>
    public class Deck : IDeck
    {
        private Card[] cards = new Card[52];

        public Deck()
        {
            // Initiate all cards in the deck
            int counter = 0;
            for (int i = 1; i <= 13; i++)
            {
                foreach (Suit suit in Suit.SuitNames)
                {
                    cards[counter] = new Card(i + 1, suit.SuitNumber);
                    counter++;
                }
            }
        }
        
        /// <summary>
        /// Get All Cards
        /// </summary>
        /// <returns></returns>
        public Card[] GetAllCards()
        {
            return this.cards;
        }

        /// <summary>
        /// Get Card
        /// </summary>
        public Card GetCard(int value)
        {
            return this.cards[value];
        }

        /// <summary>
        /// Use Shuffle Sort Algorithm
        /// </summary>
        public void Shuffle()
        {
            // Intialize Random
            Random random = new Random();

            for (int i = cards.Length - 1; i > 0; i--)
            {
                // Randomly select a pointer
                int pointer = random.Next(i + 1);
                Card selectedCard = cards[pointer];
                cards[pointer] = cards[i];
                cards[i] = selectedCard;
            }
        }
    }
}
