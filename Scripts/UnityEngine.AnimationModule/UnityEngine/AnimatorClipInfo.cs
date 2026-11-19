using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
public struct AnimatorClipInfo
{
	private int m_ClipInstanceID;

	private float m_Weight;
}
