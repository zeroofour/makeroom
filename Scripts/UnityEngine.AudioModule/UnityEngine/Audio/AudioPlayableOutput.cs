using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/Audio/Public/AudioSource.h")]
[StaticAccessor("AudioPlayableOutputBindings", StaticAccessorType.DoubleColon)]
public struct AudioPlayableOutput
{
	private PlayableOutputHandle m_Handle;
}
