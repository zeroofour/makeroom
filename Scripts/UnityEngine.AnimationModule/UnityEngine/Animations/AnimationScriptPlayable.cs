using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations;

[StaticAccessor("AnimationScriptPlayableBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationScriptPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
public struct AnimationScriptPlayable : IEquatable<AnimationScriptPlayable>
{
	private PlayableHandle m_Handle = default;

	private static readonly AnimationScriptPlayable m_NullPlayable;

	internal AnimationScriptPlayable(PlayableHandle handle)
	{
	}

	public PlayableHandle GetHandle()
	{
		return default;
	}

	public bool Equals(AnimationScriptPlayable other)
	{
		return false;
	}
}
