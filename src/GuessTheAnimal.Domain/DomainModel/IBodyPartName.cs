namespace GuessTheAnimal.Domain.DomainModel
{
    /// <summary>
    /// When implemented indicates that the object "has-a" body part
    /// </summary>
    public interface IBodyPartName
    {
        /// <summary>
        /// The body part that the object has
        /// </summary>
        /// <returns>The body part</returns>
        string BodyPartName();
    }
}