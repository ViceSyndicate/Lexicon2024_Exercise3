using Lexicon2024_Exercise3._3.Animals;

namespace Lexicon2024_Exercise3._3
{
    // ALSO CONTAINS 3.4 Mer polymorfism
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3.3 13F: Bird.cs
            // 3.3 14F: Animal.cs

            List<Animal> animalList = new List<Animal>();

            Horse horse = new Horse("Black Jack", 450, 6, 10000);
            Bird bird = new Bird("Gosi", 2, 2, 30);
            Dog dog = new Dog("Bosso", 8, 5, "Small");
            Dog dog2 = new Dog("Limbo", 7, 12, "Small");
            Hedgehog hedgehog = new Hedgehog("Zonic", 3, 3, 4);
            Wolfman wolfman = new Wolfman("Logan", 88, 66, false);

            animalList.Add(horse);
            animalList.Add(bird);
            animalList.Add(dog);
            animalList.Add(dog2);
            animalList.Add(hedgehog);
            animalList.Add(wolfman);

            foreach (Animal animal in animalList)
            {
                string animalType = animal.GetType().ToString();
                // Remove namespace part of GetType();
                animalType = animal.GetType().ToString().Substring(25);
                Console.WriteLine("animalType" + " = " + animalType);
                animal.DoSound();
                if(animal is IPerson)
                {
                    IPerson person = (IPerson)animal;
                    Console.WriteLine(person.Talk());
                }
                Console.WriteLine("----------------------");
            }

            List<Dog> dogList = new List<Dog>();
            //dogList.Add(horse);

            //3.4 9F: För att Horse är en annan klass än List<Dog>
            // Även om båda är "children" av Animal

            //3.4 10F: Animal. Eftersom att alla andra klasser inheritar ifrån Animal.

            Console.WriteLine("STATS");
            foreach (Animal animal in animalList)
            {
                Console.WriteLine(animal.Stats());
            }

            //3.4 13F: För varje Animal objekt I animalList.
            //Skriv ut strängen som returneras av Stats() funktionen
            //Som varje klass overridar med en extra property

            Console.WriteLine("----------------------");
            foreach(Animal animal in animalList)
            {
                if(animal is Dog) 
                {
                    Dog tempDog = (Dog)animal;
                    Console.WriteLine(tempDog.Growl());
                    Console.WriteLine(animal.Stats());
                }
            }
            //3.4 14F: Growl() funktionen finns inte I Animal klassen
            // och måste först castas till en Dog efter en if(animal is Dog) check.
        }
    }
}