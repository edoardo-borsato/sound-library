namespace SoundLibrary.Device
{
    public interface IDevicesFinder
    {
        IEnumerable<string> GetAll();
    }
}