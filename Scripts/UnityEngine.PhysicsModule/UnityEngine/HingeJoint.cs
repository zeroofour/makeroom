using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/Physics/HingeJoint.h")]
[NativeClass("Unity::HingeJoint")]
public class HingeJoint : Joint
{
	public JointMotor motor
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public JointLimits limits
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public JointSpring spring
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public bool useMotor
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool useLimits
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool useSpring
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[SpecialName]
	private void get_motor_Injected(out JointMotor ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_motor_Injected(ref JointMotor value)
	{
	}

	[SpecialName]
	private void get_limits_Injected(out JointLimits ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_limits_Injected(ref JointLimits value)
	{
	}

	[SpecialName]
	private void get_spring_Injected(out JointSpring ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_spring_Injected(ref JointSpring value)
	{
	}
}
