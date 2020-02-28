using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireExample.Enums
{
    /// <summary>
    /// A Suit Class in order 
    /// </summary>
    public class Suit
    {
        public static readonly Suit DIAMONDS = new Suit(1, "CLUBS", "C");
        public static readonly Suit CLUBS = new Suit(2, "DIAMONDS", "D");
        public static readonly Suit HEARTS = new Suit(3, "HEARTS", "H");
        public static readonly Suit SPADES = new Suit(4, "SPADES", "S");

        public static IEnumerable<Suit> SuitNames
        {
            get
            {
                yield return DIAMONDS;
                yield return CLUBS;
                yield return HEARTS;
                yield return SPADES;
            }
        }

        private readonly int suitNumber;
        private readonly string suitName;
        private readonly string suitFace;

        public Suit(int suitNumber, string suitName, string suitFace)
        {
            this.suitNumber = suitNumber;
            this.suitName = suitName;
            this.suitFace = suitFace;
        }

        public int SuitNumber
        {
            get { return this.suitNumber; }
        }

        public string SuitName
        {
            get { return this.suitName; }
        }

        public string SuitFace
        {
            get { return this.suitFace; }
        }

        public static Suit GetSuit(int index)
        {
            return Suit.SuitNames.ElementAt(index);
        }

        public static string GetSuitName(int index)
        {
            return Suit.SuitNames.ElementAt(index).SuitName;
        }

        public static Suit GetSuitDetail(int index)
        {
            return Suit.SuitNames.ElementAt(index);
        }
    }
}