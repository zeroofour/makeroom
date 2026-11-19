using System;
using UnityEngine;

namespace Mirror.Examples.BenchmarkIdle;

[AddComponentMenu(null)]
public class BenchmarkIdleNetworkManager : NetworkManager
{
	[Header("Spawns")]
	public int spawnAmount;

	public float interleave;

	public GameObject spawnPrefab;

	[Range(0f, 1f)]
	public float spawnPositionRatio;

	private System.Random random;

	private void SpawnAll()
	{
	}

	public override Transform GetStartPosition()
	{
		return null;
	}

	public override void OnStartServer()
	{
	}
}
