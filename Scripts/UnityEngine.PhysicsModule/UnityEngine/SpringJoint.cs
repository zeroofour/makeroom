using UnityEngine.Bindings;

namespace UnityEngine;

[NativeClass("Unity::SpringJoint")]
[NativeHeader("Modules/Physics/SpringJoint.h")]
public class SpringJoint : Joint
{
	public float spring
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float damper
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float minDistance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float maxDistance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float tolerance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}
}
