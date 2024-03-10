using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Lexicon2024_Exercise3;

namespace Lexicon2024_Exercise3
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            
            if (age <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(age), "Age must be a positive number.");
            }
            try
            {
                pers.Age = Convert.ToUInt32(age);
                //pers.Age = (uint) age;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void SetFirstName(Person pers, string fName)
        {
            try
            {
                pers.FName = fName;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void SetLastName(Person pers, string lName)
        {
            try
            {
                pers.LName = lName;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void SetHeight(Person pers, double height)
        {
            try
            {
                pers.Height = height;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void SetWeight(Person pers, double weight)
        {
            try
            {
                pers.Weight = weight;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person newPerson = new Person();

            try
            {
                newPerson.Age = Convert.ToUInt32(age);
                //newPerson.Age = (uint)age; // Doesn't trigger exception
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            newPerson.FName = fname;
            newPerson.LName = lname;
            newPerson.Height = height;
            newPerson.Weight = weight;
            return newPerson;
        }
        public uint GetAge(Person person)
        {
            return person.Age;
        }
        public string GetFirstName(Person person)
        {
            return person.FName;
        }
        public string GetLastName(Person person)
        {
            return person.LName;
        }
        public double GetHeight(Person person)
        {
            try
            {
                return person.Height;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return 0.0;
            }
        }
        public double GetWeight(Person person)
        {
            try
            {
                return person.Weight;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0.0;
            }
        }
        public string ToString(Person person)
        {
            string personString = $"{GetFirstName(person)}, {GetLastName(person)}, " +
                $"Age: {GetAge(person)}, {GetHeight(person)}cm, {GetWeight(person)}kg.";
            return personString;
        }
    }
}
