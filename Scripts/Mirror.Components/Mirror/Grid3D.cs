using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

public struct Grid3D<T>(int initialCapacity)
{
	private readonly Dictionary<Vector3Int, HashSet<T>> grid = null;

	private readonly Vector3Int[] neighbourOffsets = null;

	public void Add(Vector3Int position, T value)
	{
	}

	private void GetAt(Vector3Int position, HashSet<T> result)
	{
	}

	public void GetWithNeighbours(Vector3Int position, HashSet<T> result)
	{
	}

	public void ClearNonAlloc()
	{
	}
}
