using UnityEngine;

namespace Mirror;

[AddComponentMenu("Network/Network Rigidbody 2D (Reliable)")]
public class NetworkRigidbodyReliable2D : NetworkTransformReliable
{
	private Rigidbody2D rb;

	private bool wasKinematic;

	private bool clientAuthority => false;

	protected override void OnValidate()
	{
	}

	protected override void Awake()
	{
	}

	public override void OnStopServer()
	{
	}

	public override void OnStopClient()
	{
	}

	private void FixedUpdate()
	{
	}

	protected override void OnTeleport(Vector3 destination)
	{
	}

	protected override void OnTeleport(Vector3 destination, Quaternion rotation)
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
