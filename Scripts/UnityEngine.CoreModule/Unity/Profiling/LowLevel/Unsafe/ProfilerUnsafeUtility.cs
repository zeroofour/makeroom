using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Profiling.LowLevel.Unsafe;

[NativeHeader("Runtime/Profiler/ScriptBindings/ProfilerUnsafeUtility.bindings.h")]
[UsedByNativeCode]
public static class ProfilerUnsafeUtility
{
	[ThreadSafe]
	public static ProfilerCategoryDescription GetCategoryDescription(ushort categoryId)
	{
		return default;
	}

	[ThreadSafe]
	public static IntPtr CreateMarker(string name, ushort categoryId, MarkerFlags flags, int metadataCount)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static void BeginSample(IntPtr markerPtr)
	{
	}

	[ThreadSafe]
	public static void EndSample(IntPtr markerPtr)
	{
	}

	internal unsafe static string Utf8ToString(byte* chars, int charsLen)
	{
		return null;
	}

	private static void GetCategoryDescription_Injected(ushort categoryId, out ProfilerCategoryDescription ret)
	{
		ret = default;
	}
}
