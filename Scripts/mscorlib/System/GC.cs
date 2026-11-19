using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace System;

public static class GC
{
	internal static readonly object EPHEMERON_TOMBSTONE;

	private static void RecordPressure(long bytesAllocated)
	{
	}

	internal static void register_ephemeron_array(Ephemeron[] array)
	{
	}

	private static object get_ephemeron_tombstone()
	{
		return null;
	}

	internal static void GetMemoryInfo(out uint highMemLoadThreshold, out ulong totalPhysicalMem, out uint lastRecordedMemLoad, out UIntPtr lastRecordedHeapSize, out UIntPtr lastRecordedFragmentation)
	{
		highMemLoadThreshold = default;
		totalPhysicalMem = default;
		lastRecordedMemLoad = default;
		lastRecordedHeapSize = default;
		lastRecordedFragmentation = default;
	}

	public static void AddMemoryPressure(long bytesAllocated)
	{
	}

	public static void RemoveMemoryPressure(long bytesAllocated)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static void KeepAlive(object obj)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static void _SuppressFinalize(object o)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static void SuppressFinalize(object obj)
	{
	}

	private static void _ReRegisterForFinalize(object o)
	{
	}

	public static void ReRegisterForFinalize(object obj)
	{
	}
}
