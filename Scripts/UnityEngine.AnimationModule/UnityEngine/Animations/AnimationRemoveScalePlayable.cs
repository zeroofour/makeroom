using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationRemoveScalePlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[StaticAccessor("AnimationRemoveScalePlayableBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Modules/Animation/Director/AnimationRemoveScalePlayable.h")]
[RequiredByNativeCode]
internal struct AnimationRemoveScalePlayable : IEquatable<AnimationRemoveScalePlayable>
{
	private PlayableHandle m_Handle = default;

	private static readonly AnimationRemoveScalePlayable m_NullPlayable;

	internal AnimationRemoveScalePlayable(PlayableHandle handle)
	{
	}

	public PlayableHandle GetHandle()
	{
		return default;
	}

	public bool Equals(AnimationRemoveScalePlayable other)
	{
		return false;
	}
}
