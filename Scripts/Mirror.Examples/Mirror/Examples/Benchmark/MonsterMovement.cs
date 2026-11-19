using UnityEngine;

namespace Mirror.Examples.Benchmark;

public class MonsterMovement : NetworkBehaviour
{
	public float speed;

	[Header("Note: use 0.1 to test change detection, 0.5 is too high!")]
	public float movementProbability;

	public float movementDistance;

	private bool moving;

	private Vector3 start;

	private Vector3 destination;

	public override void OnStartServer()
	{
	}

	[ServerCallback]
	private void Update()
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
