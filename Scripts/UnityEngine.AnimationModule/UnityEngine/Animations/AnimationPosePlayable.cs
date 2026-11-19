using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationPosePlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[StaticAccessor("AnimationPosePlayableBindings", StaticAccessorType.DoubleColon)]
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/Director/AnimationPosePlayable.h")]
internal struct AnimationPosePlayable : IEquatable<AnimationPosePlayable>
{
	private PlayableHandle m_Handle = default;

	private static readonly AnimationPosePlayable m_NullPlayable;

	internal AnimationPosePlayable(PlayableHandle handle)
	{
	}

	public PlayableHandle GetHandle()
	{
		return default;
	}

	public bool Equals(AnimationPosePlayable other)
	{
		return false;
	}
}
