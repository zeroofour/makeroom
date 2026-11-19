using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[RequiredByNativeCode]
[NativeHeader("Modules/Physics/SphereCollider.h")]
public class SphereCollider : Collider
{
	public Vector3 center
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public float radius
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[SpecialName]
	private void get_center_Injected(out Vector3 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_center_Injected(ref Vector3 value)
	{
	}
}
