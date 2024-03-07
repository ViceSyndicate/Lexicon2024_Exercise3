using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon2024_Exercise3._3.Animals
{
    internal class Horse : Animal
    {
        int sellPrice;
        public Horse(string name, int weightInKg, int age, int value) : base(name, weightInKg, age)
        {
            this.sellPrice = value;
        }
        internal override void DoSound()
        {
            Console.WriteLine("Neigh");
        }
    }
}
