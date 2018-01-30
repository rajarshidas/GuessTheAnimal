namespace GuessTheAnimal.Domain.DomainModel
{
    /// <summary>
    /// When implemented indicates that the object "has-a" body part
    /// </summary>
    public interface IBodyPart
    {
        /// <summary>
        /// The body part that the object has
        /// </summary>
        /// <returns>The body part</returns>
        string BodyPart();
    }
}