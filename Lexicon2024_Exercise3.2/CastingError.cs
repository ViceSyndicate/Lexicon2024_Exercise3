using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon2024_Exercise3._2
{
    internal class CastingError : UserError
    {
        internal override string UEMessage()
        {
            return "You tried to cast a variable to another data tyoe. This fired an error!";
        }
    }
}
