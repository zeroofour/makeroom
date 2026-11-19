using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[NativeHeader("Modules/Animation/AnimatorControllerParameter.h")]
[NativeType(CodegenOptions.Custom, "MonoAnimatorControllerParameter")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
[NativeAsStruct]
[UsedByNativeCode]
public class AnimatorControllerParameter
{
	internal string m_Name;

	internal AnimatorControllerParameterType m_Type;

	internal float m_DefaultFloat;

	internal int m_DefaultInt;

	internal bool m_DefaultBool;

	public string name => null;

	public int nameHash => 0;

	public AnimatorControllerParameterType type => (AnimatorControllerParameterType)0;

	public override bool Equals(object o)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
