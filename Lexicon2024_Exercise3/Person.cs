using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lexicon2024_Exercise3
{

    /*
     * How am I supposed to add the Try part of the try-catch?
     * 
     * Kasta ett undantag av typen ArgumentException i varje property om dess
     * validering inte fullföljs, undantaget ska innehålla ett beskrivande meddelande. 
     * Se till att hantera undantagen i Program-klassen med en try-catch block.
     */
    internal class Person
    {
        private uint age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        /*
        public Person(string fName, string lName)
        {
            FName = fName;
            LName = lName;
        }
        */

        public uint Age
        {
            get { return age; }
            set
            {
                try
                {
                    if (value > 0) { age = value; }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine($"Age setting failed: {e.Message}");
                    //age = 0;
                }
            }
        }

        public string FName
        {
            get { return fName; }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    //Console.WriteLine("First Name has to be 3-10 Characters.");
                    //ArgumentException e = new ArgumentException("First Name has to be 3-10 Characters.");
                    throw new ArgumentException("First Name has to be 3-10 Characters.");
                }
                else
                {
                    fName = value;
                }
            }
        }
        public string LName
        {
            get { return lName; }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    //Console.WriteLine("Last Name has to be 3-15 Characters.");
                    throw new ArgumentException("Last Name has to be 3-15 Characters.");
                }
                else
                {
                    lName = value;
                }
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                try { height = value; }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                try { weight = value; }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
