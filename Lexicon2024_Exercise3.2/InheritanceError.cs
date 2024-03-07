using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon2024_Exercise3._2
{
    internal class InheritanceError : UserError
    {
        internal override string UEMessage()
        {
            return "This Function is overriding a inherited " +
                "abstract class & function";
        }
    }
}
