using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon2024_Exercise3._3.Animals
{
    internal class Horse : Animal
    {
        public int SellPrice { get; set; }
        public Horse(string name, int weightInKg, int age, int value) : base(name, weightInKg, age)
        {
            this.SellPrice = value;
        }
        internal override void DoSound()
        {
            Console.WriteLine("Neigh");
        }
        public override string Stats()
        {
            return $"Name: {Name}, Weight: {WeightInKg}, Age: {Age}, SellPrice: {SellPrice}";
        }
    }
}
