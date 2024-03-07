using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon2024_Exercise3._3
{
    abstract  class Animal
    {
        protected Animal(string name, int weightInKg, int age)
        {
            Name = name;
            WeightInKg = weightInKg;
            Age = age;
        }

        public string Name { get; set; }
        public int WeightInKg { get; set; }
        public int Age { get; set; }
        internal abstract void DoSound();
    }
}