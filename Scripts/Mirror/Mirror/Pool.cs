using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Mirror;

public class Pool<T>
{
	private readonly Stack<T> objects;

	private readonly Func<T> objectGenerator;

	public int Count => 0;

	public Pool(Func<T> objectGenerator, int initialCapacity)
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
