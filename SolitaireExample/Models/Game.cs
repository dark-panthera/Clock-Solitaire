using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireExample.Models
{
    public class Game : IGame
    {
        // Set card amount to 52
        private int cardsAmount = 52;

        // Initialize Random
        private Random random = new Random();

        // Set 13 piles of cards
        private Pile[] pile = new Pile[13];

        // Remaining cards
        private List<Card>  remainingCards = new List<Card>(),
                            allCards = new List<Card>();

        //Deck to generate the cards
        private Deck deck = new Deck();

        /// <summary>
        /// 
        /// Initalize Game
        /// 
        /// </summary>
        public Game()
        {
            // Shuffle Deck
            deck.Shuffle();

            // Fill Remaing Cards from All Cards in deck after Shuffle
            this.remainingCards = deck.GetAllCards().ToList();

            // Set Current Pile to 0
            int currentPile = 0;

            Pile tempPile = new Pile();
            // Loop through 52 cards
            for (int i = 1; i <= this.cardsAmount; i++)
            {
                // Add Cards to Pile
                tempPile.AddCards(deck.GetCard(i - 1));

                // Set current Pile to the List of Piles
                pile[currentPile] = tempPile;

                // After every 4 card, initialize a new Pile
                if (i % 4 == 0)
                {
                    // Set New Pile
                    tempPile = new Pile();

                    // Increment current Pile
                    currentPile++;
                }
            }
        }

        /// <summary>
        /// Get All Cards
        /// </summary>
        /// <returns></returns>
        public List<Card> GetAllCards()
        {
            // Add all excluded cards into complete cards
            this.allCards.AddRange(this.remainingCards);

            //return card in order
            return this.allCards;
        }
 
        /// <summary>
        /// 
        /// Randomly Select a card from the Last Pile
        /// 
        /// </summary>
        /// <returns></returns>
        public Card GetRandomCardFromLastPile()
        {
            // Get All Cards from the last Pile (13)
            List<Card> list = this.pile.Last().GetCards();

            //Random pointer
            int pointer = random.Next(list.Count);

            // Selected Card
            Card selectedCard = list[pointer];

            // Remove card from Pile
            list.Remove(selectedCard);

            // Return selected Card
            return selectedCard;
        }

        /// <summary>
        /// 
        /// Swap Card
        /// 
        /// </summary>
        /// <param name="card"></param>
        /// <param name="pileId"></param>
        /// <returns></returns>
        public Card SwapCard(Card card, int pileId)
        {
            // Add to current Order position
            this.allCards.Add(card);
            // Remove from exclusions
            this.remainingCards.Remove(card);
            //Get the swapped card
            return this.pile[pileId - 1].SwapCard(card);
        }

        /// <summary>
        /// Ascending Order of All Cards
        /// </summary>
        /// <returns></returns>
        public string AscendingOrder()
        {
            StringBuilder sb = new StringBuilder();
            int pointer = 1;

            for (int i = 0; i <= allCards.Count - 1; i++)
            {
                if (pointer % 13 != 0)
                {
                    pointer++;
                    sb.Append($"{allCards[i].GetData()} ");
                }
                else
                {
                    pointer = 1;
                    sb.AppendLine($"{allCards[i].GetData()} ");
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 
        /// Override to string the pile list
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.pile.Length; i++)
            {
                sb.AppendLine($"{ this.pile[i].ToString()} ");
            }

            return sb.ToString();
        }
    }
}