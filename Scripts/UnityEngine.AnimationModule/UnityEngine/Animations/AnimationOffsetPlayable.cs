using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationOffsetPlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationOffsetPlayable.h")]
[StaticAccessor("AnimationOffsetPlayableBindings", StaticAccessorType.DoubleColon)]
[RequiredByNativeCode]
internal struct AnimationOffsetPlayable : IEquatable<AnimationOffsetPlayable>
{
	private PlayableHandle m_Handle = default;

	private static readonly AnimationOffsetPlayable m_NullPlayable;

	internal AnimationOffsetPlayable(PlayableHandle handle)
	{
	}

	public PlayableHandle GetHandle()
	{
		return default;
	}

	public bool Equals(AnimationOffsetPlayable other)
	{
		return false;
	}
}
