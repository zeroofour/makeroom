using UnityEngine;

namespace Mirror;

internal class HexGrid2D
{
	internal float cellRadius;

	private Vector2 originOffset;

	private readonly float sqrt3Div3;

	private readonly float oneDiv3;

	private readonly float twoDiv3;

	private readonly float sqrt3;

	private readonly float sqrt3Div2;

	private static readonly Cell2D[] neighborCellsBase;

	internal HexGrid2D(ushort visRange)
	{
	}

	internal Vector2 CellToWorld(Cell2D cell)
	{
		return default;
	}

	internal Cell2D WorldToCell(Vector2 position)
	{
		return default;
	}

	private Cell2D RoundToCell(float q, float r)
	{
		return default;
	}

	internal void GetNeighborCells(Cell2D center, Cell2D[] neighbors)
	{
	}
}
