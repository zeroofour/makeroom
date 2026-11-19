using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeClass("Unity::Joint")]
[RequireComponent(typeof(Rigidbody))]
[NativeHeader("Modules/Physics/Joint.h")]
public class Joint : Component
{
	public Rigidbody connectedBody
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ArticulationBody connectedArticulationBody
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector3 axis
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Vector3 anchor
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Vector3 connectedAnchor
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public bool autoConfigureConnectedAnchor
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float breakForce
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float breakTorque
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool enableCollision
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool enablePreprocessing
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float massScale
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float connectedMassScale
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
	private void get_axis_Injected(out Vector3 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_axis_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void get_anchor_Injected(out Vector3 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_anchor_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void get_connectedAnchor_Injected(out Vector3 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_connectedAnchor_Injected(ref Vector3 value)
	{
	}
}
