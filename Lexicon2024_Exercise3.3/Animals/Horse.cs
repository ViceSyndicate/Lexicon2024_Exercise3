using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon2024_Exercise3._3.Animals
{
    internal class Horse : Animal
    {
        public Horse(string name, int weightInKg, int age) : base(name, weightInKg, age)
        {
        }

        internal override void DoSound()
        {
            Console.WriteLine("Neigh");
        }
    }
}
