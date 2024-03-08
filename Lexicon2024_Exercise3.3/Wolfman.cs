using Lexicon2024_Exercise3._3.Animals;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon2024_Exercise3._3
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int weightInKg, int age, bool isFeral) : base(name,weightInKg,age,isFeral)
        {

        }
        string IPerson.Talk()
        {
            return "Bork? I'm a wolfman?";
        }
        public override string Stats()
        {
            return $"Name: {Name}, Weight: {WeightInKg}, Age: {Age}, IsFeral: {IsFeral}";
        }
    }
}