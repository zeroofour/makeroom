using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Jobs.LowLevel.Unsafe;

[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
[NativeHeader("Runtime/Jobs/JobSystem.h")]
public static class JobsUtility
{
	internal delegate void PanicFunction_();

	internal static PanicFunction_ PanicFunction;

	[RequiredByNativeCode]
	private static void InvokePanicFunction()
	{
	}
}
