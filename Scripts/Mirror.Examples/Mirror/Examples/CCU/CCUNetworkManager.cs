using System;
using UnityEngine;

namespace Mirror.Examples.CCU;

[AddComponentMenu(null)]
public class CCUNetworkManager : NetworkManager
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
