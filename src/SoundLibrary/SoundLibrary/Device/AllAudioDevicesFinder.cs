using OpenTK.Audio.OpenAL;
using SoundLibrary.Errors;

namespace SoundLibrary.Device;

public class AllAudioDevicesFinder : AudioDeviceFinderBase
{
    public AllAudioDevicesFinder(IAlcAudioErrorsManagerFactory alcAudioErrorsManagerFactory) : base(alcAudioErrorsManagerFactory)
    {
    }

    public override IEnumerable<string> GetAll()
    {
        return GetAll(AlcGetStringList.AllDevicesSpecifier);
    }
}