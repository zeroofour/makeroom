using System;
using System.Collections.Generic;

namespace Telepathy;

public class MagnificentReceivePipe
{
	private struct Entry(int connectionId, EventType eventType, ArraySegment<byte> data)
	{
		public int connectionId = 0;

		public EventType eventType = EventType.Connected;

		public ArraySegment<byte> data = default;
	}

	private readonly Queue<Entry> queue;

	private Pool<byte[]> pool;

	private Dictionary<int, int> queueCounter;

	public int TotalCount => 0;

	public int PoolCount => 0;

	public MagnificentReceivePipe(int MaxMessageSize)
	{
	}

	public int Count(int connectionId)
	{
		return 0;
	}

	public void Enqueue(int connectionId, EventType eventType, ArraySegment<byte> message)
	{
	}

	public bool TryPeek(out int connectionId, out EventType eventType, out ArraySegment<byte> data)
	{
		connectionId = default;
		eventType = default;
		data = default;
		return false;
	}

	public bool TryDequeue()
	{
		return false;
	}

	public void Clear()
	{
	}
}
