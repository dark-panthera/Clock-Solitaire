using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireExample.Exceptions
{
    public class InvalidException : Exception
    {
        public InvalidException(string message) : base(message)
        {

        }
    }
}