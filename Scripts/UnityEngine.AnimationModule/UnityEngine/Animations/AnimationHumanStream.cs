using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations;

[RequiredByNativeCode]
[NativeHeader("Modules/Animation/Director/AnimationHumanStream.h")]
[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationHumanStream.bindings.h")]
public struct AnimationHumanStream
{
	private IntPtr stream;
}
