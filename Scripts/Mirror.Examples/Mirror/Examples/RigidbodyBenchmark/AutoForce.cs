using UnityEngine;

namespace Mirror.Examples.RigidbodyBenchmark;

[RequireComponent(typeof(Rigidbody))]
public class AutoForce : NetworkBehaviour
{
	public Rigidbody rigidbody3d;

	public float force;

	public float forceProbability;

	protected override void OnValidate()
	{
	}

	[ServerCallback]
	private void FixedUpdate()
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
