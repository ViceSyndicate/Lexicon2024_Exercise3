using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon2024_Exercise3._3.Animals.Birds
{
    internal class Pelican : Bird
    {
        public bool FishEater { get; set; }
        public Pelican(string name, int weightInKg, int age, double wingSpan, bool fishEater) : base(name, weightInKg, age, wingSpan)
        {
            this.FishEater = fishEater;
        }
    }
}