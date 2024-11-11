using OpenTK.Audio.OpenAL;
using SoundLibrary.Errors;

namespace SoundLibrary.Device;

public class CaptureDevicesFinder : AudioDeviceFinderBase
{
    public CaptureDevicesFinder(IAlcAudioErrorsManagerFactory alcAudioErrorsManagerFactory) : base(alcAudioErrorsManagerFactory)
    {
    }

    public override IEnumerable<string> GetAll()
    {
        return GetAll(AlcGetStringList.CaptureDeviceSpecifier);
    }
}