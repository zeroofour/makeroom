using System;
using System.Collections.Generic;

namespace Mirror;

public class Batcher
{
	private readonly int threshold;

	public const int TimestampSize = 8;

	private readonly Queue<NetworkWriterPooled> batches;

	private NetworkWriterPooled batch;

	private double batchTimestamp;

	public static int MessageHeaderSize(int messageSize)
	{
		return 0;
	}

	public static int MaxMessageOverhead(int messageSize)
	{
		return 0;
	}

	public Batcher(int threshold)
	{
	}

	public void AddMessage(ArraySegment<byte> message, double timeStamp)
	{
	}

	private static void CopyAndReturn(NetworkWriterPooled batch, NetworkWriter writer)
	{
	}

	public bool GetBatch(NetworkWriter writer)
	{
		return false;
	}

	public void Clear()
	{
	}
}
