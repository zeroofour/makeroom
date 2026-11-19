using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[StaticAccessor("AnimatorControllerPlayableBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
[NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
public struct AnimatorControllerPlayable : IEquatable<AnimatorControllerPlayable>
{
	private PlayableHandle m_Handle = default;

	private static readonly AnimatorControllerPlayable m_NullPlayable;

	internal AnimatorControllerPlayable(PlayableHandle handle)
	{
	}

	public PlayableHandle GetHandle()
	{
		return default;
	}

	public void SetHandle(PlayableHandle handle)
	{
	}

	public bool Equals(AnimatorControllerPlayable other)
	{
		return false;
	}
}
