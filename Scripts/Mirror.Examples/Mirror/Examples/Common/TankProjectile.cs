using UnityEngine;

namespace Mirror.Examples.Common;

[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody))]
[AddComponentMenu(null)]
[RequireComponent(typeof(CapsuleCollider))]
public class TankProjectile : MonoBehaviour
{
	private enum CapsuleColliderDirection
	{
		XAxis = 0,
		YAxis = 1,
		ZAxis = 2
	}

	[Header("Components")]
	public Rigidbody rigidBody;

	public CapsuleCollider capsuleCollider;

	[Header("Settings")]
	public float destroyAfter;

	public float force;

	private void OnValidate()
	{
	}

	private void Reset()
	{
	}

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
