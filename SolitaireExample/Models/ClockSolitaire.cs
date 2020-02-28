using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireExample.Models
{
    public class ClockSolitaire : IClockSolitaire
    {
        private int moves = 0;
        private string lastKing = "";
        private string choice = string.Empty;

        /// <summary>
        /// 
        /// Play: in manual or automativ game
        /// 
        /// </summary>
        /// <param name="autoMate"></param>
        public void Play(bool autoMate = false)
        {
            int totalMoves = 52;
            string choice = string.Empty;

            moves = 0;

            Game game = new Game();
            //Get First selectedItem
            Card currentSelectedCard = game.GetRandomCardFromLastPile();
            //Rank Number
            int rankNumber = currentSelectedCard.GetRank().RankValue;

            //Increment the moves count immediately due to the initiale amount
            moves++;

            do
            {
                // Get the newly swapped value
                currentSelectedCard = game.SwapCard(currentSelectedCard, rankNumber);

                // If current selected card is not null ... check the rank
                if (currentSelectedCard != null)
                {
                    rankNumber = currentSelectedCard.GetRank().RankValue;

                    // If Rank Face is K add to last king
                    if (currentSelectedCard.GetRank().RankFace == "K")
                    {
                        lastKing = currentSelectedCard.GetData();
                    }

                    moves++;
                }
                else
                {
                    // Display Results
                    Results(game);
                    break;
                }

                if (autoMate == false)
                {
                    Console.WriteLine(game.AscendingOrder());

                    Console.WriteLine("Play another card? # to Stop");

                    choice = Console.ReadLine();
                }

            } while (autoMate ? moves < totalMoves : !(choice.Equals("#")));
        }

        /// <summary>
        /// 
        /// Display Results
        /// 
        /// </summary>
        /// <param name="game"></param>
        public void Results(Game game)
        {
            // User wins if moves count to 52
            if (moves == 52)
            {
                Console.WriteLine("You Won!");
            }
            else
            {
                Console.WriteLine("You Lost!");
            }
            Console.WriteLine($"{moves}, {lastKing} \n");

            Console.WriteLine($"Inputs: ");

            // Displays Card list in Ascending
            Console.WriteLine(AscendingOrder(game.GetAllCards()));

            // Provide a choice to the user
            Console.WriteLine("Do you want to Start Over? # to Stop");
            choice = Console.ReadLine();

            // Keep looping until the user inputs #
            if (choice != "#")
            {
                Choice();
            }
        }

        /// <summary>
        /// 
        /// Sort the Cards in Ascending Order
        /// 
        /// </summary>
        /// <param name="cardInOrder"></param>
        /// <returns></returns>
        public string AscendingOrder(List<Card> cardInOrder)
        {
            StringBuilder sb = new StringBuilder();
            int pointer = 1;

            for (int i = 0; i<= cardInOrder.Count - 1; i++)
            {
                if (pointer % 13 != 0)
                {
                    pointer++;
                    sb.Append($"{cardInOrder[i].GetData()} ");
                }
                else
                {
                    pointer = 1;
                    sb.AppendLine($"{cardInOrder[i].GetData()} ");
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// Options: Whether to allow the game to be automated or else manually by pressing any key
        /// 
        /// </summary>
        public void Choice()
        {
            string choice = string.Empty;

            Console.WriteLine($"Play Manually? Type (M) ");
            Console.WriteLine($"Play Automatically? Type (A) ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "A": Play(true); break;
                default: Play(false); break;
            }
        }
    }
}
