using System.Collections.Concurrent;
using System.Diagnostics;

namespace Mirror.SimpleWeb;

internal class BufferBucket : IBufferOwner
{
	public readonly int arraySize;

	private readonly ConcurrentQueue<ArrayBuffer> buffers;

	internal int _current;

	public BufferBucket(int arraySize)
	{
	}

	public ArrayBuffer Take()
	{
		return null;
	}

	public void Return(ArrayBuffer buffer)
	{
	}

	[Conditional("DEBUG")]
	private void IncrementCreated()
	{
	}

	[Conditional("DEBUG")]
	private void DecrementCreated()
	{
	}
}
