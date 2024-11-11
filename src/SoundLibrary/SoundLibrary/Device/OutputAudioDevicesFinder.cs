using OpenTK.Audio.OpenAL;
using SoundLibrary.Errors;

namespace SoundLibrary.Device;

public class OutputAudioDevicesFinder : AudioDeviceFinderBase
{
    public OutputAudioDevicesFinder(IAlcAudioErrorsManagerFactory errorsManagerFactory) : base(errorsManagerFactory)
    {
    }

    public override IEnumerable<string> GetAll()
    {
        return GetAll(AlcGetStringList.DeviceSpecifier);
    }
}