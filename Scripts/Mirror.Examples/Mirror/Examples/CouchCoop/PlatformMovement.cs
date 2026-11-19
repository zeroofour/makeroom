using UnityEngine;

namespace Mirror.Examples.CouchCoop;

public class PlatformMovement : NetworkBehaviour
{
	private bool onPlatform;

	private Transform platformTransform;

	private Vector3 lastPlatformPosition;

	public override void OnStartAuthority()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnCollisionExit(Collision collision)
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
