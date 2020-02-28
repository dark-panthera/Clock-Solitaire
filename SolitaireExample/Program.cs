using SolitaireExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockSolitaire clockSolitaire = new ClockSolitaire();
            clockSolitaire.Choice();

            Console.ReadLine();
        }
    }
}
