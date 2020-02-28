using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireExample.Models
{
    /// <summary>
    /// 
    /// There are 13 piles ... 4 cards each
    /// 
    /// </summary>
    public class Pile : IPile
    {
        private Random random = new Random();
        private List<Card> cards = new List<Card>();

        public Pile()
        {

        }

        /// <summary>
        /// 
        /// Add Cards to Pile
        /// 
        /// </summary>
        /// <param name="card"></param>
        public void AddCards(Card card)
        {
            this.cards.Add(card);
        }

        /// <summary>
        /// 
        /// Get Cards within the pile
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Card> GetCards()
        {
            return this.cards;
        }

        /// <summary>
        /// 
        /// Swap Card
        /// 
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public Card SwapCard(Card card)
        {
            // List of Cards
            List<Card> list = this.cards;

            // Get All Cards Face Down
            list = list.Where(x => x.IsFaceUp == false).ToList();
            if (list.Count > 0)
            {
                // Get First Card
                int pointer = list.Count - 1;
                // get currently selected card
                Card selectedCard = list[pointer];
                // set card face up
                card.SetFaceUp();

                // remove card from pointer
                this.cards.RemoveAt(pointer);

                // add card to cards
                this.cards.Add(card);

                // return selected card
                return selectedCard;
            }

            return null;
        }
    }
}
