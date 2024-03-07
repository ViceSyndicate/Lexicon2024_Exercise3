using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon2024_Exercise3._3.Animals
{
    internal class Hedgehog : Animal
    {
        int nrOfSpikes;
        public Hedgehog(string name, int weightInKg, int age, int nrOfSpikes) : base(name, weightInKg, age)
        {
            this.nrOfSpikes = nrOfSpikes;
        }
        internal override void DoSound()
        {
            Console.WriteLine("Squeak!");
        }

    }
}
