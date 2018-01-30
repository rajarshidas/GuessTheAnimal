using System.Collections.Generic;
using GuessTheAnimal.Domain.DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GuessTheAnimal.Tests
{
    [TestClass]
    public class GuessTheAnimalService_GuessTheAnimalShould
    {
        private readonly GuessTheAnimalService _guessTheAnimalService;

        public GuessTheAnimalService_GuessTheAnimalShould()
        {
            _guessTheAnimalService = new GuessTheAnimalService();
            AnimalBase elephant = new Animal("Elephant", "grey", "trumpets", "trunk");
            AnimalBase lion = new Animal("Lion", "yellow", "roars", "mane");

            List<AnimalBase> animals = new List<AnimalBase>();
            animals.Add(elephant);
            animals.Add(lion);

            _guessTheAnimalService.AddAnimals(animals);
        }

        [TestMethod]
        public void ReturnElephantAsChosenAnimalGivenValues_grey_trumpets_trunk()
        {
            string result = _guessTheAnimalService.GuessTheAnimal("grey", "trumpets", "trunk");
            Assert.AreEqual("You chose Elephant", result);

            result = _guessTheAnimalService.GuessTheAnimal("gRey", "Trumpets", "TRunk");
            Assert.AreEqual("You chose Elephant", result);
        }

        [TestMethod]
        public void ReturnNotFoundGivenValues_red_beeps_wheel()
        {
            string result = _guessTheAnimalService.GuessTheAnimal("red", "beeps", "wheel");
            Assert.AreEqual("No matching animal found", result);
        }
    }
}