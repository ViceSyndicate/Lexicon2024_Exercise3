using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon2024_Exercise3._3.Animals
{
    internal class Dog : Animal
    {
        public string Size { get; set; }
        public Dog(string name, int weight, int age, string size) : base(name, weight, age)
        {
            this.Size = size;
        }
        internal override void DoSound()
        {
            Console.WriteLine("Woff!");
        }
        public override string Stats()
        {
            return $"Name: {Name}, Weight: {WeightInKg}, Age: {Age}, Size: {Size}";
        }
        public string Growl()
        {
            return "Grrrr";
        }
    }
}
