using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeClass("Unity::CharacterJoint")]
[NativeHeader("Modules/Physics/CharacterJoint.h")]
public class CharacterJoint : Joint
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("TargetRotation not in use for Unity 5 and assumed disabled.", true)]
	public Quaternion targetRotation;

	[Obsolete("TargetAngularVelocity not in use for Unity 5 and assumed disabled.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Vector3 targetAngularVelocity;

	[Obsolete("RotationDrive not in use for Unity 5 and assumed disabled.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public JointDrive rotationDrive;

	public Vector3 swingAxis
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public SoftJointLimitSpring twistLimitSpring
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public SoftJointLimitSpring swingLimitSpring
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public SoftJointLimit lowTwistLimit
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public SoftJointLimit highTwistLimit
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public SoftJointLimit swing1Limit
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public SoftJointLimit swing2Limit
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public bool enableProjection
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float projectionDistance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float projectionAngle
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
	private void get_swingAxis_Injected(out Vector3 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_swingAxis_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void get_twistLimitSpring_Injected(out SoftJointLimitSpring ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_twistLimitSpring_Injected(ref SoftJointLimitSpring value)
	{
	}

	[SpecialName]
	private void get_swingLimitSpring_Injected(out SoftJointLimitSpring ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_swingLimitSpring_Injected(ref SoftJointLimitSpring value)
	{
	}

	[SpecialName]
	private void get_lowTwistLimit_Injected(out SoftJointLimit ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_lowTwistLimit_Injected(ref SoftJointLimit value)
	{
	}

	[SpecialName]
	private void get_highTwistLimit_Injected(out SoftJointLimit ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_highTwistLimit_Injected(ref SoftJointLimit value)
	{
	}

	[SpecialName]
	private void get_swing1Limit_Injected(out SoftJointLimit ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_swing1Limit_Injected(ref SoftJointLimit value)
	{
	}

	[SpecialName]
	private void get_swing2Limit_Injected(out SoftJointLimit ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_swing2Limit_Injected(ref SoftJointLimit value)
	{
	}
}
