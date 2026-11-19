using Mirror;
using StinkySteak.NetcodeBenchmark;
using UnityEngine;

namespace StinkySteak.MirrorBenchmark;

public class SineMoveYBehaviour : NetworkBehaviour
{
	[SerializeField]
	private BehaviourConfig _config;

	private SinMoveYWrapper _wrapper;

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
