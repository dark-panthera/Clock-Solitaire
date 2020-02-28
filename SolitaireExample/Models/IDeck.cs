using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireExample.Models
{
    public interface IDeck
    {
        Card[] GetAllCards();
        Card GetCard(int value);
        string ToString();
        void Shuffle();
    }
}
