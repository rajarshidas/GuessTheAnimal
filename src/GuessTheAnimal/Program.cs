using System;
using System.Collections.Generic;
using GuessTheAnimal.Domain.DomainModel;

namespace GuessTheAnimal
{
    public class Program
    {
        public static void Main(string[] args)
        {  
            AnimalBase elephant = new Animal("Elephant", "grey", "trumpets", "trunk");
            AnimalBase lion = new Animal("Lion","yellow", "roars", "mane");

            List<AnimalBase> animals = new List<AnimalBase>();
            animals.Add(elephant);
            animals.Add(lion);

            GuessTheAnimalService animalService = new GuessTheAnimalService();
            animalService.AddAnimals(animals);

            List<string> animalNames = animalService.GetAnimalNames();

            Console.WriteLine("Hi! Please choose one animal in your head from the following list of animals:");
            foreach (string animalName in animalNames)
            {
                Console.WriteLine(animalName);
            }
            Console.WriteLine("If you have made your choice, then please");
            Console.WriteLine("1. Enter what is the colour of the animal you've chosen:");
            string colour = Console.ReadLine();
            Console.WriteLine("2. Enter the name of a body part that this animal has:");
            string bodypartname = Console.ReadLine();
            Console.WriteLine("... and finally, please enter a sound that this animal makes:");
            string sound = Console.ReadLine();

            Console.WriteLine(animalService.GuessTheAnimal(colour, sound, bodypartname));
            Console.Read();
        }
    }
}
