using UnityEngine;

namespace Mirror.Examples.CCU;

public class Player : NetworkBehaviour
{
	public Vector3 cameraOffset;

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

	public override void OnStopLocalPlayer()
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
