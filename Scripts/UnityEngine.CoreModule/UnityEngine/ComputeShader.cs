using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[UsedByNativeCode]
public sealed class ComputeShader : Object
{
	[NativeMethod(Name = "ComputeShaderScripting::FindKernel", HasExplicitThis = true, IsFreeFunction = true, ThrowsException = true)]
	[RequiredByNativeCode]
	public int FindKernel(string name)
	{
		return 0;
	}

	[NativeMethod(Name = "ComputeShaderScripting::GetKernelThreadGroupSizes", HasExplicitThis = true, IsFreeFunction = true, ThrowsException = true)]
	public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z)
	{
		x = default;
		y = default;
		z = default;
	}
}
