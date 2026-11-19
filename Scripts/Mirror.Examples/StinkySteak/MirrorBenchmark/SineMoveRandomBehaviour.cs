using Mirror;
using StinkySteak.NetcodeBenchmark;
using UnityEngine;

namespace StinkySteak.MirrorBenchmark;

public class SineMoveRandomBehaviour : NetworkBehaviour
{
	[SerializeField]
	private BehaviourConfig _config;

	private SinRandomMoveWrapper _wrapper;

	public override void OnStartServer()
	{
	}

	private void FixedUpdate()
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
