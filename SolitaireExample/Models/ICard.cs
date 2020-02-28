using SolitaireExample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireExample.Models
{
    interface ICard
    {
        Rank GetRank();
        string GetData();
        void SetFaceUp();
    }
}
