using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon2024_Exercise3._3.Animals.Birds
{
    internal class Flamingo : Bird
    {
        public bool IsGoofy { get; set; }
        public Flamingo(string name, int weightInKg, int age, bool isGoofy) : base(name, weightInKg, age, weightInKg)
        { 
            this.IsGoofy = isGoofy;
        }
    }
}
