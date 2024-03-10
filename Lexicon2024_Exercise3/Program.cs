namespace Lexicon2024_Exercise3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("b", "reak");
            //Person person1 = new Person("Baba", "Is You");
            
            PersonHandler personHandler = new PersonHandler();

            Person unborn = personHandler.CreatePerson(-1, "Bobby", "Baby", 2, 4);
            Console.WriteLine(personHandler.ToString(unborn));
            Console.WriteLine("-----------------------------");

            Person person2 = personHandler.CreatePerson(2, "John", "Doe", 200, 90);
            Console.WriteLine(personHandler.ToString(person2));
            Console.WriteLine("-----------------------------");

            Person person3 = personHandler.CreatePerson(-2, "John", "Doe", 200, 90);
            Console.WriteLine(personHandler.ToString(person3));
            Console.WriteLine("-----------------------------");

            Person person4 = personHandler.CreatePerson(2, "1", "1", 2, 2);
            Console.WriteLine(personHandler.ToString(person4));
            Console.WriteLine("-----------------------------");

            personHandler.SetAge(person4, 69);
            personHandler.SetFirstName(person4, "Danny");
            personHandler.SetLastName(person4, "De Vito");
            personHandler.SetWeight(person4, 111.1);
            personHandler.SetHeight(person4, 155.3);
            Console.WriteLine(personHandler.ToString(person4));
            Console.WriteLine("-----------------------------");

        }
    }
}
