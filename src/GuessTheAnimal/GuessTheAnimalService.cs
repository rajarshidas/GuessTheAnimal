using System;
using System.Collections.Generic;
using GuessTheAnimal.Domain.DomainModel;

namespace GuessTheAnimal
{
    public class GuessTheAnimalService : IGuessTheAnimalService
    {
        public List<AnimalBase> Animals = new List<AnimalBase>();


        public string GuessTheAnimal(string colour, string sound, string bodypartname)
        {
            foreach (AnimalBase animal in Animals)
            {
                if (string.Equals(colour, animal.Colour, StringComparison.CurrentCultureIgnoreCase)
                    && string.Equals(sound, animal.SoundMade(), StringComparison.CurrentCultureIgnoreCase)
                    && string.Equals(bodypartname, animal.BodyPartName(), StringComparison.CurrentCultureIgnoreCase))
                {
                    return $"You chose {animal.AnimalName}";
                }
            }
            return "No matching animal found";
        }

        public void AddAnimals(List<AnimalBase> animals)
        {
            Animals.AddRange(animals);
        }

        public List<string> GetAnimalNames()
        {
            List<string> animalNames = new List<string>();
            foreach(AnimalBase animal in Animals)
            {
                animalNames.Add(animal.AnimalName);
            }

            return animalNames;
        }
    }

    public interface IGuessTheAnimalService
    {
        /// <summary>
        /// Attempts to guess the animal based on parameters passed to it
        /// </summary>
        /// <param name="colour">The colour of the animal</param>
        /// <param name="sound">The sound it makes</param>
        /// <param name="bodypartname">A body part it posseses</param>
        /// <returns>If match is found then the string "You chose (matching animal name)", else "No matching animal found"</returns>
        string GuessTheAnimal(string colour, string sound, string bodypartname);

        /// <summary>
        /// Supports adding animal instances by the consumer using this service
        /// </summary>
        /// <param name="animals">The list of animal instances</param>
        void AddAnimals(List<AnimalBase> animals);

        /// <summary>
        /// Returns the animal names
        /// </summary>
        /// <returns>Animal names as a list</returns>
        List<string> GetAnimalNames();
    }
}