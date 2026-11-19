using UnityEngine;

namespace Mirror.Examples.CCU;

public class Monster : NetworkBehaviour
{
	public float speed;

	public float movementProbability;

	public float movementDistance;

	private bool moving;

	private Vector3 start;

	private Vector3 destination;

	private Transform tf;

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
