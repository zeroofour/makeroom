using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations;

[RequiredByNativeCode]
[StaticAccessor("AnimationLayerMixerPlayableBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationLayerMixerPlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationLayerMixerPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
public struct AnimationLayerMixerPlayable : IEquatable<AnimationLayerMixerPlayable>
{
	private PlayableHandle m_Handle = default;

	private static readonly AnimationLayerMixerPlayable m_NullPlayable;

	internal AnimationLayerMixerPlayable(PlayableHandle handle, bool singleLayerOptimization = true)
	{
	}

	public PlayableHandle GetHandle()
	{
		return default;
	}

	public bool Equals(AnimationLayerMixerPlayable other)
	{
		return false;
	}

	[NativeThrows]
	private static void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value)
	{
	}
}
