using UnityEngine.Bindings;

namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/AudioMixer.h")]
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
public class AudioMixer : Object
{
	[NativeMethod]
	public bool SetFloat(string name, float value)
	{
		return false;
	}
}
