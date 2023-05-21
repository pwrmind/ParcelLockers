namespace ParcelLockers.Domain;
public class DeviceManager
{
    List<IParcelLocker> _parcelLockerList;

    public List<IParcelLocker> ParcelLockerList { get => _parcelLockerList; set => _parcelLockerList = value; }
}
