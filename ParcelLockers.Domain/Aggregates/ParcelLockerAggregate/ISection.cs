namespace ParcelLocker.Domain.Aggregates.ParcelLockerAggregate;


public interface ISection
{
    ICollection<ILocker> Lockers { get; }
}