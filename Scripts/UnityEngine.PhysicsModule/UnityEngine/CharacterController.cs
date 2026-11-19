using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/Physics/CharacterController.h")]
public class CharacterController : Collider
{
	public Vector3 velocity => default;

	public bool isGrounded
	{
		[NativeName("IsGrounded")]
		get
		{
			return false;
		}
	}

	public float skinWidth
	{
		set
		{
		}
	}

	public float minMoveDistance
	{
		set
		{
		}
	}

	public CollisionFlags Move(Vector3 motion)
	{
		return CollisionFlags.None;
	}

	private CollisionFlags Move_Injected(ref Vector3 motion)
	{
		return CollisionFlags.None;
	}

	[SpecialName]
	private void get_velocity_Injected(out Vector3 ret)
	{
		ret = default;
	}
}
