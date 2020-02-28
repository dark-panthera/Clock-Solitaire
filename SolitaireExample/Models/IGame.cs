using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireExample.Models
{
    public interface IGame
    {
        List<Card> GetAllCards();
        Card GetRandomCardFromLastPile();
        Card SwapCard(Card card, int pileId);
        string AscendingOrder();
    }
}
