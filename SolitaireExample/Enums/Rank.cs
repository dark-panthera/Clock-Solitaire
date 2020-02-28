using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireExample.Enums
{
    public class Rank
    {
        public static readonly Rank ACE = new Rank(1, "ACE", "A");
        public static readonly Rank TWO = new Rank(2, "TWO", "2");
        public static readonly Rank THREE = new Rank(3, "THREE", "3");
        public static readonly Rank FOUR = new Rank(4, "FOUR", "4");
        public static readonly Rank FIVE = new Rank(5, "FIVE", "5");

        public static readonly Rank SIX = new Rank(6, "SIX", "6");
        public static readonly Rank SEVEN = new Rank(7, "SEVEN", "7");
        public static readonly Rank EIGHT = new Rank(8, "EIGHT", "8");
        public static readonly Rank NINE = new Rank(9, "NINE", "9");
        public static readonly Rank TEN = new Rank(10, "TEN", "T");

        public static readonly Rank JACK = new Rank(11, "JACK", "J");
        public static readonly Rank QUEEN = new Rank(12, "QUEEN", "Q");
        public static readonly Rank KING = new Rank(13, "KING", "K");

        public static IEnumerable<Rank> FaceNames
        {
            get
            {
                yield return ACE;
                yield return TWO;
                yield return THREE;
                yield return FOUR;
                yield return FIVE;

                yield return SIX;
                yield return SEVEN;
                yield return EIGHT;

                yield return NINE;
                yield return TEN;

                yield return JACK;
                yield return QUEEN;
                yield return KING;
            }
        }

        private readonly int rankValue;
        private readonly string rankName;
        private readonly string rankFace;

        public Rank(int rankValue, string rankName, string rankFace)
        {
            this.rankValue = rankValue;
            this.rankName = rankName;
            this.rankFace = rankFace;
        }

        public int RankValue
        {
            get { return this.rankValue; }
        }

        public string RankName
        {
            get { return this.rankName; }
        }

        public string RankFace
        {
            get { return this.rankFace; }
        }

        public static Rank GetRank(int index)
        {
            return Rank.FaceNames.ElementAt(index);
        }

        public static string GetRankName(int index)
        {
            return Rank.FaceNames.ElementAt(index).RankName;
        }

        public static Rank GetRankDetail(int index)
        {
            return Rank.FaceNames.ElementAt(index);
        }
    }
}
