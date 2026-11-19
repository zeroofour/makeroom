using UnityEngine;

namespace Mirror.Examples.PredictionBenchmark;

[AddComponentMenu(null)]
public class NetworkManagerStackedPrediction : NetworkManager
{
	[Header("Spawns")]
	public int spawnAmount;

	public GameObject spawnPrefab;

	public float interleave;

	[Tooltip("Stacked Cubes are only stable if solver iterations are high enough!\nDefault is 1, max is 255.")]
	public int solverIterations;

	public int solverVelocityIterations;

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
