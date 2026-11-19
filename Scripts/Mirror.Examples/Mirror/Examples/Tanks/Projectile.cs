using UnityEngine;

namespace Mirror.Examples.Tanks;

public class Projectile : NetworkBehaviour
{
	public float destroyAfter;

	public Rigidbody rigidBody;

	public float force;

	public override void OnStartServer()
	{
	}

	private void Start()
	{
	}

	[Server]
	private void DestroySelf()
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
}
