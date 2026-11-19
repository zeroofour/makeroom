using UnityEngine;

namespace Mirror;

internal class HexGrid3D
{
	internal float cellRadius;

	internal float cellHeight;

	private Vector3 originOffset;

	private readonly float sqrt3Div3;

	private readonly float oneDiv3;

	private readonly float twoDiv3;

	private readonly float sqrt3;

	private readonly float sqrt3Div2;

	private static readonly Cell3D[] neighborCellsBase;

	internal HexGrid3D(ushort visRange, ushort height)
	{
	}

	internal Vector3 CellToWorld(Cell3D cell)
	{
		return default;
	}

	internal Cell3D WorldToCell(Vector3 position)
	{
		return default;
	}

	private Cell3D RoundToCell(float q, float r, int layer)
	{
		return default;
	}

	internal void GetNeighborCells(Cell3D center, Cell3D[] neighbors)
	{
	}
}
