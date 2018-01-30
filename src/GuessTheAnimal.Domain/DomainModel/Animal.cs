using System;

namespace GuessTheAnimal.Domain.DomainModel
{
    /// <summary>
    /// The template that can be used to create an Animal
    /// that has the ability to make a sound, has a body part
    /// and is of a certain colour
    /// </summary>
    public class Animal : AnimalBase
    {
        public string Sound { private get; set; }
        public string Bodypartname { private get; set; }

        public Animal(string animalname, string colour, string sound, string bodypartname)
        {
            this.AnimalName = animalname;
            this.Colour = colour;
            this.Sound = sound;
            this.Bodypartname = bodypartname;
        }

        public override string SoundMade()
        {
            return Sound;
        }

        public override string BodyPartName()
        {
            return Bodypartname;
        }

    }
}