using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Modules/ParticleSystem/ParticleSystemRenderer.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemRendererScriptBindings.h")]
[RequireComponent(typeof(Transform))]
public sealed class ParticleSystemRenderer : Renderer
{
	[RequiredByNativeCode]
	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshes", HasExplicitThis = true)]
	public int GetMeshes([Out][NotNull("ArgumentNullException")] Mesh[] meshes)
	{
		return 0;
	}
}
