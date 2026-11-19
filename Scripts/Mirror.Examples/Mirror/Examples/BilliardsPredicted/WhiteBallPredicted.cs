using UnityEngine;

namespace Mirror.Examples.BilliardsPredicted;

public class WhiteBallPredicted : NetworkBehaviour
{
	public LineRenderer dragIndicator;

	public float dragTolerance;

	public Rigidbody rigidBody;

	public float forceMultiplier;

	public float maxForce;

	internal Vector3 startPosition;

	private bool draggingStartedOverObject;

	private bool MouseToWorld(out Vector3 position)
	{
		position = default;
		return false;
	}

	private void Awake()
	{
	}

	[ClientCallback]
	private void Update()
	{
	}

	[ClientCallback]
	private void OnGUI()
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
