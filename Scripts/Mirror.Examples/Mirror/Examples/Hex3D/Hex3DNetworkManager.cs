using UnityEngine;

namespace Mirror.Examples.Hex3D;

[AddComponentMenu(null)]
public class Hex3DNetworkManager : NetworkManager
{
	[Header("Spawns")]
	public GameObject spawnPrefab;

	[Range(1f, 8000f)]
	public ushort spawnPrefabsCount;

	[Range(1f, 10f)]
	public byte spawnPrefabSpacing;

	public new static Hex3DNetworkManager singleton => null;

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
