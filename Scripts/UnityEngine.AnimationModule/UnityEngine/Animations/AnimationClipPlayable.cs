using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
[StaticAccessor("AnimationClipPlayableBindings", StaticAccessorType.DoubleColon)]
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable>
{
	private PlayableHandle m_Handle;

	public PlayableHandle GetHandle()
	{
		return default;
	}

	public bool Equals(AnimationClipPlayable other)
	{
		return false;
	}
}
