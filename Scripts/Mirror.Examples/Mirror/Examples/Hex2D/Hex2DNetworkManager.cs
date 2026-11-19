using UnityEngine;

namespace Mirror.Examples.Hex2D;

[AddComponentMenu(null)]
[RequireComponent(typeof(HexSpatialHash2DInterestManagement))]
public class Hex2DNetworkManager : NetworkManager
{
	[Header("Spawns")]
	public GameObject spawnPrefab;

	[Range(1f, 3000f)]
	[Tooltip("Number of prefabs to spawn in a flat 2D grid across the scene.")]
	public ushort spawnPrefabsCount;

	[Tooltip("Spacing between grid points in meters.")]
	[Range(1f, 10f)]
	public byte spawnPrefabSpacing;

	[SerializeField]
	[ReadOnly]
	[Header("Diagnostics")]
	private HexSpatialHash2DInterestManagement hexSpatialHash2DInterestManagement;

	public new static Hex2DNetworkManager singleton => null;

	public override void OnValidate()
	{
	}

	public override void OnStartClient()
	{
	}

	public override void OnStartServer()
	{
	}
}
