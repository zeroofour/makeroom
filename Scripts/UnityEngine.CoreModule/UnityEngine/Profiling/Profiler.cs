using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Profiling;

[NativeHeader("Runtime/Allocator/MemoryManager.h")]
[NativeHeader("Runtime/ScriptingBackend/ScriptingApi.h")]
[NativeHeader("Runtime/Profiler/Profiler.h")]
[NativeHeader("Runtime/Utilities/MemoryUtilities.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Profiler/ScriptBindings/Profiler.bindings.h")]
[MovedFrom("UnityEngine")]
public sealed class Profiler
{
	[NativeConditional("ENABLE_PROFILER")]
	public static void EndThreadProfiling()
	{
	}
}
