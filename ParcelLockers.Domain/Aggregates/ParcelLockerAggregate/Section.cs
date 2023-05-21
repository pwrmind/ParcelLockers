public class Section : ISection
{
    private List<ILocker> lockers;

    List<ILocker> Lockers { get => lockers; set => lockers = value; }

    ICollection<ILocker> ISection.Lockers => throw new NotImplementedException();
}