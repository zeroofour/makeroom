using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables;

[NativeHeader("Runtime/Export/Director/TextureMixerPlayable.bindings.h")]
[NativeHeader("Runtime/Graphics/Director/TextureMixerPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("TextureMixerPlayableBindings", StaticAccessorType.DoubleColon)]
public struct TextureMixerPlayable : IEquatable<TextureMixerPlayable>
{
	private PlayableHandle m_Handle;

	public PlayableHandle GetHandle()
	{
		return default;
	}

	public bool Equals(TextureMixerPlayable other)
	{
		return false;
	}
}
