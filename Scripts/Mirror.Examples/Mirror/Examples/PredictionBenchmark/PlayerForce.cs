using UnityEngine;

namespace Mirror.Examples.PredictionBenchmark;

public class PlayerForce : NetworkBehaviour
{
	public float force;

	private void Update()
	{
	}

	[Command]
	private void CmdApplyForce(NetworkIdentity cube, Vector3 impulse)
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_CmdApplyForce__NetworkIdentity__Vector3(NetworkIdentity cube, Vector3 impulse)
	{
	}

	protected static void InvokeUserCode_CmdApplyForce__NetworkIdentity__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	static PlayerForce()
	{
	}
}
