namespace GuessTheAnimal.Domain.DomainModel
{
    /// <summary>
    /// The base class that contains attributes that all animals inherit
    /// </summary>
    public abstract class AnimalBase : IMakesSound, IBodyPartName
    {
        public string AnimalName { get; set; }
        public string Colour { get; set; }
        public abstract string SoundMade();
        public abstract string BodyPartName();
    }
}
