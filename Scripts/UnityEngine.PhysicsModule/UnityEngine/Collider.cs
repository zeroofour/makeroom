using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[RequiredByNativeCode]
[RequireComponent(typeof(Transform))]
[NativeHeader("Modules/Physics/Collider.h")]
public class Collider : Component
{
	public bool enabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Rigidbody attachedRigidbody
	{
		[NativeMethod("GetRigidbody")]
		get
		{
			return null;
		}
	}

	public bool isTrigger
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Bounds bounds => default;

	public PhysicMaterial material
	{
		[NativeMethod("GetClonedMaterial")]
		get
		{
			return null;
		}
		[NativeMethod("SetMaterial")]
		set
		{
		}
	}

	public Vector3 ClosestPoint(Vector3 position)
	{
		return default;
	}

	private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void get_bounds_Injected(out Bounds ret)
	{
		ret = default;
	}
}
