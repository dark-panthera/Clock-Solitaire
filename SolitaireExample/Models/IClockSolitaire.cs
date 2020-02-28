using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireExample.Models
{
    public interface IClockSolitaire
    {
        void Play(bool autoMate = false);
        void Results(Game game);
        string AscendingOrder(List<Card> cardInOrder);
        void Choice();
    }
}