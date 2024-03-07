using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon2024_Exercise3._3.Animals
{
    internal class Worm : Animal
    {
        public bool IsPoisonus { get; set; }
        public Worm(string name, int weightInKg, int age, bool isPoisonus) : base(name, weightInKg, age)
        {
            this.IsPoisonus = isPoisonus;
        }
        internal override void DoSound()
        {
            Console.WriteLine("...");
        }
    }
}
