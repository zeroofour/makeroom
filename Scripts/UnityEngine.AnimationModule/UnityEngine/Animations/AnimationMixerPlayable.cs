using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations;

[RequiredByNativeCode]
[StaticAccessor("AnimationMixerPlayableBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationMixerPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/Director/AnimationMixerPlayable.h")]
public struct AnimationMixerPlayable : IEquatable<AnimationMixerPlayable>
{
	private PlayableHandle m_Handle = default;

	private static readonly AnimationMixerPlayable m_NullPlayable;

	internal AnimationMixerPlayable(PlayableHandle handle)
	{
	}

	public PlayableHandle GetHandle()
	{
		return default;
	}

	public bool Equals(AnimationMixerPlayable other)
	{
		return false;
	}
}
