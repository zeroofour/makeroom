using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine;

[RequireComponent(typeof(Transform))]
[NativeHeader("Modules/Physics/Rigidbody.h")]
public class Rigidbody : Component
{
	public Vector3 velocity
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Vector3 angularVelocity
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public float drag
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float angularDrag
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float mass
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool useGravity
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isKinematic
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool freezeRotation
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public RigidbodyConstraints constraints
	{
		get
		{
			return RigidbodyConstraints.None;
		}
		set
		{
		}
	}

	public CollisionDetectionMode collisionDetectionMode
	{
		get
		{
			return CollisionDetectionMode.Discrete;
		}
		set
		{
		}
	}

	public Vector3 position
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Quaternion rotation
	{
		set
		{
		}
	}

	public RigidbodyInterpolation interpolation
	{
		get
		{
			return RigidbodyInterpolation.None;
		}
		set
		{
		}
	}

	public float sleepThreshold
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public void MovePosition(Vector3 position)
	{
	}

	public void MoveRotation(Quaternion rot)
	{
	}

	public void Sleep()
	{
	}

	public void AddForce(Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
	{
	}

	[ExcludeFromDocs]
	public void AddForce(Vector3 force)
	{
	}

	[SpecialName]
	private void get_velocity_Injected(out Vector3 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_velocity_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void get_angularVelocity_Injected(out Vector3 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_angularVelocity_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void get_position_Injected(out Vector3 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_position_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void set_rotation_Injected(ref Quaternion value)
	{
	}

	private void MovePosition_Injected(ref Vector3 position)
	{
	}

	private void MoveRotation_Injected(ref Quaternion rot)
	{
	}

	private void AddForce_Injected(ref Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
	{
	}
}
