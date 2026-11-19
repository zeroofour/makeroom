using System;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine;

[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
internal static class ResourcesAPIInternal
{
	[FreeFunction("Resources_Bindings::FindObjectsOfTypeAll")]
	[TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
	public static Object[] FindObjectsOfTypeAll(Type type)
	{
		return null;
	}

	[FreeFunction("GetShaderNameRegistry().FindShader")]
	public static Shader FindShaderByName(string name)
	{
		return null;
	}

	[FreeFunction("Resources_Bindings::Load")]
	[NativeThrows]
	[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
	public static Object Load(string path, [NotNull("ArgumentNullException")] Type systemTypeInstance)
	{
		return null;
	}

	[FreeFunction("Resources_Bindings::LoadAll")]
	[NativeThrows]
	public static Object[] LoadAll([NotNull("ArgumentNullException")] string path, [NotNull("ArgumentNullException")] Type systemTypeInstance)
	{
		return null;
	}
}
