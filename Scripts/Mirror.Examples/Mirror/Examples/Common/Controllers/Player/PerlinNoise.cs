using UnityEngine;

namespace Mirror.Examples.Common.Controllers.Player;

[AddComponentMenu(null)]
[ExecuteInEditMode]
public class PerlinNoise : MonoBehaviour
{
	public float scale;

	public float heightMultiplier;

	public float offsetX;

	public float offsetY;

	[ContextMenu("Generate Terrain")]
	private void GenerateTerrain()
	{
	}

	private TerrainData GenerateTerrainData(TerrainData terrainData)
	{
		return null;
	}
}
