using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon2024_Exercise3._3.Animals.Birds
{
    internal class Swan : Bird
    {
        public bool IsElegant { get; set; }
        public Swan(string name, int weightInKg, int age, double wingSpan, bool IsElegant) : base(name, weightInKg, age, wingSpan)
        {
            this.IsElegant = IsElegant;
        }
    }
}
