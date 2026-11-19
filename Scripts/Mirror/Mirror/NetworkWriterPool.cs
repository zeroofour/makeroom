using System.Runtime.CompilerServices;

namespace Mirror;

public static class NetworkWriterPool
{
	private static readonly Pool<NetworkWriterPooled> Pool;

	public static int Count => 0;

	public static NetworkWriterPooled Get()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Return(NetworkWriterPooled writer)
	{
	}
}
