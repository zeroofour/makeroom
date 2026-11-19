using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Modules/Physics/CapsuleCollider.h")]
[RequiredByNativeCode]
public class CapsuleCollider : Collider
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

	public float height
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int direction
	{
		get
		{
			return 0;
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
