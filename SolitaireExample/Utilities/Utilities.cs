using SolitaireExample.Exceptions;
using SolitaireExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireExample
{
    public class Utilities
    {
        // Set each Deck Size to 13
        private static int DeckSize = 13;

        /// <summary>
        /// Validate if Face Suit is greater than 1 and smaller than 13
        /// 
        /// </summary>
        public static bool ValidationFaceSuit(int faceValue, int suitValue)
        {
            bool valid = true;

            if ((faceValue < 1) ||
                (suitValue > 13))
            {
                valid = false;
            }

            if ((suitValue < 1) ||
                (suitValue > 4))
            {
                valid = false;
            }

            return valid;
        }

        /// <summary>
        /// 
        /// Validation of Deck value which is between 1 and 52
        /// 
        /// </summary>
        /// <param name="deckValue"></param>
        /// <returns></returns>
        public static bool ValidationDeck(int deckValue)
        {
            bool valid = true;

            if ((deckValue < 1) ||
                (deckValue > 52))
            {
                valid = false;
            }

            return valid;
        }

        /// <summary>
        /// 
        /// Set Deck Value, throw an exception if deck value is out of index
        /// 
        /// </summary>
        /// <param name="faceValue"></param>
        /// <param name="suitValue"></param>
        /// <returns></returns>
        public static int SetDeckValue(int faceValue, int suitValue)
        {
            if (!Utilities.ValidationFaceSuit(faceValue, suitValue))
            {
                throw new InvalidException("Value out of index");
            }

            // Deck (1 - 52) * (4 - 1) + face value - 4
            int deckValue = (DeckSize * (suitValue - 1)) + faceValue - 1;

            // Deck Value
            return deckValue;
        }

        /// <summary>
        /// 
        /// Set Face Value: deck Value (1 - 52) modules (decksize 1 - 13) + 1
        /// 
        /// </summary>
        /// <param name="deckValue"></param>
        /// <returns></returns>
        public static int SetFaceValue(int deckValue)
        {
            // if face value results in 0 will set to the faceValue to 14
            int faceValue = (deckValue % DeckSize) + 1;
            if (faceValue == 0)
            {
                faceValue = 14;
            }
            return faceValue;
        }

        /// <summary>
        /// 
        /// Set the Card Deck Value between 1 to 52
        /// 
        /// </summary>
        /// <param name="deckValue"></param>
        /// <returns></returns>
        public static int SetSuitValue(int deckValue)
        {
            int suitValue = deckValue / DeckSize;

            if (deckValue % DeckSize != 0)
            {
                suitValue++;
            }
            return suitValue;
        }
    }
}