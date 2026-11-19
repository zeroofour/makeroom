using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Mirror;

public class ConcurrentPool<T>
{
	private readonly ConcurrentBag<T> objects;

	private readonly Func<T> objectGenerator;

	public int Count => 0;

	public ConcurrentPool(Func<T> objectGenerator, int initialCapacity)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public T Get()
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Return(T item)
	{
	}
}
