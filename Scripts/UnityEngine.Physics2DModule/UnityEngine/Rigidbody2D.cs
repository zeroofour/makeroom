using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
[RequireComponent(typeof(Transform))]
public sealed class Rigidbody2D : Component
{
	public Vector2 position
	{
		set
		{
		}
	}

	public float rotation
	{
		set
		{
		}
	}

	public Vector2 velocity
	{
		set
		{
		}
	}

	public RigidbodyType2D bodyType
	{
		get
		{
			return RigidbodyType2D.Dynamic;
		}
		[NativeMethod("SetBodyType_Binding")]
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

	public bool simulated
	{
		[NativeMethod("SetSimulated_Binding")]
		set
		{
		}
	}

	[SpecialName]
	private void set_position_Injected(ref Vector2 value)
	{
	}

	[SpecialName]
	private void set_velocity_Injected(ref Vector2 value)
	{
	}
}
