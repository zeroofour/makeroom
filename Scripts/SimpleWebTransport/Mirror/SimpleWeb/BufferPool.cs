using System.Diagnostics;

namespace Mirror.SimpleWeb;

public class BufferPool
{
	internal readonly BufferBucket[] buckets;

	private readonly int bucketCount;

	private readonly int smallest;

	private readonly int largest;

	public BufferPool(int bucketCount, int smallest, int largest)
	{
	}

	[Conditional("UNITY_ASSERTIONS")]
	private void Validate()
	{
	}

	public ArrayBuffer Take(int size)
	{
		return null;
	}
}
