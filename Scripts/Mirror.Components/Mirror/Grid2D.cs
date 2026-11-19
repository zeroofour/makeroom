using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

public struct Grid2D<T>(int initialCapacity)
{
	private readonly Dictionary<Vector2Int, HashSet<T>> grid = null;

	private readonly Vector2Int[] neighbourOffsets = null;

	public void Add(Vector2Int position, T value)
	{
	}

	private void GetAt(Vector2Int position, HashSet<T> result)
	{
	}

	public void GetWithNeighbours(Vector2Int position, HashSet<T> result)
	{
	}

	public void ClearNonAlloc()
	{
	}
}
