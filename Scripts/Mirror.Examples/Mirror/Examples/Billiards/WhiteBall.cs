using UnityEngine;

namespace Mirror.Examples.Billiards;

public class WhiteBall : NetworkBehaviour
{
	public LineRenderer dragIndicator;

	public Rigidbody rigidBody;

	public float forceMultiplier;

	public float maxForce;

	private Vector3 startPosition;

	private bool MouseToWorld(out Vector3 position)
	{
		position = default;
		return false;
	}

	private void Awake()
	{
	}

	[ClientCallback]
	private void OnMouseDown()
	{
	}

	[ClientCallback]
	private void OnMouseDrag()
	{
	}

	[Command(requiresAuthority = false)]
	private void CmdApplyForce(Vector3 force)
	{
	}

	[ClientCallback]
	private void OnMouseUp()
	{
	}

	[ServerCallback]
	private void OnTriggerEnter(Collider other)
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_CmdApplyForce__Vector3(Vector3 force)
	{
	}

	protected static void InvokeUserCode_CmdApplyForce__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	static WhiteBall()
	{
	}
}
