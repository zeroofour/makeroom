using System.Runtime.CompilerServices;

namespace Mirror;

public static class ConcurrentNetworkWriterPool
{
	public const int InitialCapacity = 1000;

	private static readonly ConcurrentPool<ConcurrentNetworkWriterPooled> pool;

	public static int Count => 0;

	public static ConcurrentNetworkWriterPooled Get()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Return(ConcurrentNetworkWriterPooled writer)
	{
	}
}
