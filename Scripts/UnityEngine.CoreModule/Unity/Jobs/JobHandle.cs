using System;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;

namespace Unity.Jobs;

[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
public struct JobHandle
{
	[NativeDisableUnsafePtrRestriction]
	internal IntPtr jobGroup;

	internal int version;

	[NativeMethod("ScheduleBatchedScriptingJobs", IsFreeFunction = true, IsThreadSafe = true)]
	public static void ScheduleBatchedJobs()
	{
	}
}
