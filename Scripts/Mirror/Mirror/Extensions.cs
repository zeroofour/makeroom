using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;

namespace Mirror;

public static class Extensions
{
	public static string ToHexString(this ArraySegment<byte> segment)
	{
		return null;
	}

	public static int GetStableHashCode(this string text)
	{
		return 0;
	}

	public static ushort GetStableHashCode16(this string text)
	{
		return 0;
	}

	public static string GetMethodName(this Delegate func)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void CopyTo<T>(this IEnumerable<T> source, List<T> destination)
	{
	}

	public static bool TryDequeue<T>(this Queue<T> source, out T element)
	{
		element = default;
		return false;
	}

	public static void Clear<T>(this ConcurrentQueue<T> source)
	{
	}

	public static string PrettyAddress(this IPEndPoint endPoint)
	{
		return null;
	}
}
