using UnityEngine;

namespace Mirror.Examples.BenchmarkIdle;

public class Player : NetworkBehaviour
{
	[Header("Automated Movement")]
	public bool autoMove;

	public float autoSpeed;

	public float movementProbability;

	public float movementDistance;

	private bool moving;

	private Vector3 start;

	private Vector3 destination;

	[Header("Manual Movement")]
	public float manualSpeed;

	private Transform tf;

	public override void OnStartLocalPlayer()
	{
	}

	private void AutoMove()
	{
	}

	private void ManualMove()
	{
	}

	private static bool Interrupted()
	{
		return false;
	}

	private void Update()
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
