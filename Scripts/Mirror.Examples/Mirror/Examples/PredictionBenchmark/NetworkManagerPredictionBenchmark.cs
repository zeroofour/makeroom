using UnityEngine;

namespace Mirror.Examples.PredictionBenchmark;

[AddComponentMenu(null)]
public class NetworkManagerPredictionBenchmark : NetworkManager
{
	[Header("Spawns")]
	public int spawnAmount;

	public GameObject spawnPrefab;

	public Bounds spawnArea;

	public override void Awake()
	{
	}

	private void SpawnAll()
	{
	}

	public override void OnStartServer()
	{
	}
}
