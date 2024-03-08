using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon2024_Exercise3._3.Animals
{
    internal class Bird : Animal
    {
        public double WingSpan { get; set; }
        public Bird(string name, int weightInKg, int age, double wingSpan) : base(name, weightInKg, age) { 
            this.WingSpan = wingSpan;
        }
        internal override void DoSound()
        {
            Console.WriteLine("Chirp!");
        }
        public override string Stats()
        {
            return $"Name: {Name}, Weight: {WeightInKg}, Age: {Age}, Wingspan: {WingSpan}";
        }
    }
}
