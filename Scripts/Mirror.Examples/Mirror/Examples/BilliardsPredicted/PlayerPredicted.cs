using UnityEngine;

namespace Mirror.Examples.BilliardsPredicted;

public class PlayerPredicted : NetworkBehaviour
{
	private WhiteBallPredicted whiteBall;

	private void Awake()
	{
	}

	private void ApplyForceToWhite(Vector3 force)
	{
	}

	public void OnDraggedBall(Vector3 force)
	{
	}

	private bool IsValidMove(Vector3 force)
	{
		return false;
	}

	[Command]
	private void CmdApplyForce(Vector3 force)
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

	static PlayerPredicted()
	{
	}
}
