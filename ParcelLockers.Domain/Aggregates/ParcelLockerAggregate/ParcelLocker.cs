namespace ParcelLocker.Domain.Aggregates.ParcelLockerAggregate;


public class ParcelLocker : IParcelLocker
{
    public ICollection<ISection> Sections => throw new NotImplementedException();
}
