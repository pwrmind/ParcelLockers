namespace ParcelLocker.Domain.Aggregates.ParcelLockerAggregate;


public interface IParcelLocker
{
    ICollection<ISection> Sections { get; }
}