using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon2024_Exercise3._2
{
    internal class UnknownError : UserError
    {
        internal override string UEMessage()
        {
            return "I don't really understand what this is for.";
        }
    }
}
