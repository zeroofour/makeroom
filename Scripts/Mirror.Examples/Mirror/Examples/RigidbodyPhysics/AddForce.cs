using UnityEngine;

namespace Mirror.Examples.RigidbodyPhysics;

[RequireComponent(typeof(Rigidbody))]
public class AddForce : NetworkBehaviour
{
	public Rigidbody rigidbody3d;

	public float force;

	protected override void OnValidate()
	{
	}

	private void Update()
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
