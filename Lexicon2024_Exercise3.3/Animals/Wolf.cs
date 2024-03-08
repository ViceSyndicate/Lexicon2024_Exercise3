using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon2024_Exercise3._3.Animals
{
    internal class Wolf : Animal
    {
        public bool IsFeral { get; set; }
        public Wolf(string name, int weightInKg, int age, bool isFeral) : base(name, weightInKg, age)
        {
            this.IsFeral = isFeral;
        }
        internal override void DoSound()
        {
            Console.WriteLine("Awooooo!");
        }
        public override string Stats()
        {
            return $"Name: {Name}, Weight: {WeightInKg}, Age: {Age}, IsFeral: {IsFeral}";
        }
    }
}
