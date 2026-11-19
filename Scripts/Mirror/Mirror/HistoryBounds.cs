using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

public class HistoryBounds
{
	private readonly int boundsPerBucket;

	private readonly Queue<MinMaxBounds> fullBuckets;

	private readonly int bucketLimit;

	private MinMaxBounds? currentBucket;

	private int currentBucketSize;

	private MinMaxBounds totalMinMax;

	public int boundsCount { get; private set; }

	public Bounds total => default;

	public HistoryBounds(int boundsLimit, int boundsPerBucket)
	{
	}

	public void Insert(Bounds bounds)
	{
	}

	public void Reset()
	{
	}
}
