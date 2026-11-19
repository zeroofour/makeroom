using UnityEngine;

namespace Mirror.Examples.PredictionBenchmark;

public class RandomForce : NetworkBehaviour
{
	public float force;

	public float interval;

	private PredictedRigidbody prediction;

	private Rigidbody rb => null;

	private void Awake()
	{
	}

	public override void OnStartClient()
	{
	}

	[ClientCallback]
	private void ApplyForce()
	{
	}

	[Command(requiresAuthority = false)]
	private void CmdApplyForce(Vector3 impulse)
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_CmdApplyForce__Vector3(Vector3 impulse)
	{
	}

	protected static void InvokeUserCode_CmdApplyForce__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	static RandomForce()
	{
	}
}
