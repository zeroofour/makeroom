using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Mirror.Examples.TopDownShooter;

public class NetworkTopDown : NetworkBehaviour
{
	public CanvasTopDown canvasTopDown;

	public GameObject[] enemyPrefabs;

	public Vector2 enemySpawnRangeX;

	public Vector2 enemySpawnRangeZ;

	[SyncVar(hook = "OnEnemyCounterChanged")]
	public int enemyCounter;

	public Action<int, int> _Mirror_SyncVarHookDelegate_enemyCounter;

	public int NetworkenemyCounter
	{
		get
		{
			return 0;
		}
		[param: In]
		set
		{
		}
	}

	public override void OnStartServer()
	{
	}

	public override void OnStartClient()
	{
	}

	[ServerCallback]
	public void SpawnEnemy()
	{
	}

	private void OnEnemyCounterChanged(int _Old, int _New)
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
	{
	}

	public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
	{
	}
}
