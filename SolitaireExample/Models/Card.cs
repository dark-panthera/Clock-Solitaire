using SolitaireExample.Enums;
using SolitaireExample.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireExample.Models
{
    public class Card : ICard
    {
        // 1 - 52 cards
        private readonly int deckValue = 0;
        // 2 - 14, [2-10, J, Q, K, A] = Rank
        private readonly int faceValue = 0;
        // 1 - 4 [C, D, H, S] = Suit
        private readonly int suitValue = 0;

        private bool faceUp = false;

        // Get Face Up
        public bool IsFaceUp
        {
            get { return this.faceUp; }
        }

        // Default Constructor
        public Card()
        {

        }

        // Overloaded Constructor with Deck Value
        public Card(int deckValue)
        {
            if (!Utilities.ValidationDeck(deckValue))
            {
                throw new InvalidException("Value out of index");
            }

            // Set the current Deck Value
            this.deckValue = deckValue;

            // Set the Face Value from deck value
            this.faceValue = Utilities.SetFaceValue(deckValue);

            // Set the Suit Value from deck value
            this.suitValue = Utilities.SetSuitValue(deckValue);
        }

        // Overloaded Constructor with Face Value and Suit Value
        public Card(int faceValue, int suitValue)
        {
            if (!Utilities.ValidationFaceSuit(faceValue, suitValue))
            {
                throw new InvalidException("Value out of index");
            }

            this.faceValue = faceValue;
            this.suitValue = suitValue;

            // Return deck value from facevalue and suit value
            this.deckValue = Utilities.SetDeckValue(faceValue, suitValue);
        }

        // Get Rank
        public Rank GetRank()
        {
            return Rank.GetRankDetail(this.faceValue - 2);
        }

        public string GetData()
        {
            string data = string.Empty,
                    rank = Rank.GetRank(this.faceValue - 2).RankFace,
                    suit = Suit.GetSuit(this.suitValue - 1).SuitFace;

            data = $"{rank}{suit}";

            return data;
        }

        // Set Face Up for the card
        public void SetFaceUp()
        {
            this.faceUp = true;
        }
        
        // Override to String to get the Card: Rank with Suit
        public override string ToString()
        {
            return $"{GetData()}";
        }
    }
}
