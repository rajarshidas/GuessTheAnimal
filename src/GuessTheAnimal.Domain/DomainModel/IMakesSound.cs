namespace GuessTheAnimal.Domain.DomainModel
{
    /// <summary>
    /// An interface that defines the ability to make a sound
    /// </summary>
    public interface IMakesSound
    {
        /// <summary>
        /// The sound made when this interface is implemented
        /// </summary>
        /// <returns>A string representing the sound</returns>
        string SoundMade();
    }
}