using System;
using System.Collections.Generic;

namespace Mirror;

public class Unbatcher
{
	private readonly Queue<NetworkWriterPooled> batches;

	private readonly NetworkReader reader;

	private double readerRemoteTimeStamp;

	public int BatchesCount => 0;

	private void StartReadingBatch(NetworkWriterPooled batch)
	{
	}

	public bool AddBatch(ArraySegment<byte> batch)
	{
		return false;
	}

	public bool GetNextMessage(out ArraySegment<byte> message, out double remoteTimeStamp)
	{
		message = default;
		remoteTimeStamp = default;
		return false;
	}
}
