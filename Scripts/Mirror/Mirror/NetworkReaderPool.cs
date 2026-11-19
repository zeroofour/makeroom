using System;
using System.Runtime.CompilerServices;

namespace Mirror;

public static class NetworkReaderPool
{
	private static readonly Pool<NetworkReaderPooled> Pool;

	public static int Count => 0;

	public static NetworkReaderPooled Get(byte[] bytes)
	{
		return null;
	}

	public static NetworkReaderPooled Get(ArraySegment<byte> segment)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Return(NetworkReaderPooled reader)
	{
	}
}
