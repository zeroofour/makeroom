using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations;

[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutput.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationPlayableOutput.h")]
[NativeHeader("Modules/Animation/Animator.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[StaticAccessor("AnimationPlayableOutputBindings", StaticAccessorType.DoubleColon)]
[RequiredByNativeCode]
public struct AnimationPlayableOutput
{
	private PlayableOutputHandle m_Handle;
}
