using Mirror;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(NetworkIdentity))]
[RequireComponent(typeof(NetworkTransformReliable))]
[RequireComponent(typeof(Rigidbody))]
public class Box : NetworkBehaviour
{
	[Header("Components")]
	public Rigidbody rigidBody;

	protected override void OnValidate()
	{
	}

	private void Reset()
	{
	}

	public override void OnStartServer()
	{
	}

	public override void OnStopServer()
	{
	}

	public override void OnStartClient()
	{
	}

	public override void OnStopClient()
	{
	}

	public override void OnStartLocalPlayer()
	{
	}

	public override void OnStopLocalPlayer()
	{
	}

	public override void OnStartAuthority()
	{
	}

	public override void OnStopAuthority()
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
