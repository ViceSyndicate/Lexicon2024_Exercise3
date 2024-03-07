using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon2024_Exercise3._3.Animals
{
    internal class Dog : Animal
    {
        string size;
        Dog(string size, string name, int weight, int age) : base(name, weight, age)
        {
            this.size = size;
        }
        internal override void DoSound()
        {
            Console.WriteLine("Woff!");
        }
    }
}
