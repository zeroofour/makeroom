using UnityEngine;

namespace Mirror.Examples.RigidbodyBenchmark;

[AddComponentMenu(null)]
public class RigidbodyBenchmarkNetworkManager : NetworkManager
{
	[Header("Spawns")]
	public GameObject spawnPrefab;

	public int spawnAmount;

	public float interleave;

	private void SpawnAll()
	{
	}

	public override void OnStartServer()
	{
	}
}
