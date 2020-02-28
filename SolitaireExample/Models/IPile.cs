using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireExample.Models
{
    public interface IPile
    {
        void AddCards(Card card);
        List<Card> GetCards();
        Card SwapCard(Card card);
        string ToString();
    }
}