using UnityEngine;

namespace Mirror.Examples.MultipleAdditiveScenes;

[RequireComponent(typeof(Rigidbody))]
public class PhysicsCollision : NetworkBehaviour
{
	[Tooltip("how forcefully to push this object")]
	public float force;

	public Rigidbody rigidbody3D;

	protected override void OnValidate()
	{
	}

	private void Start()
	{
	}

	[ServerCallback]
	private void OnCollisionStay(Collision other)
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
