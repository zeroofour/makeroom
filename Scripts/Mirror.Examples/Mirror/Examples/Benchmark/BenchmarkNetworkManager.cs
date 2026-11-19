using UnityEngine;

namespace Mirror.Examples.Benchmark;

[AddComponentMenu(null)]
public class BenchmarkNetworkManager : NetworkManager
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
