using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeClass("Unity::ConfigurableJoint")]
[NativeHeader("Modules/Physics/ConfigurableJoint.h")]
public class ConfigurableJoint : Joint
{
	public Vector3 secondaryAxis
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public ConfigurableJointMotion xMotion
	{
		get
		{
			return ConfigurableJointMotion.Locked;
		}
		set
		{
		}
	}

	public ConfigurableJointMotion yMotion
	{
		get
		{
			return ConfigurableJointMotion.Locked;
		}
		set
		{
		}
	}

	public ConfigurableJointMotion zMotion
	{
		get
		{
			return ConfigurableJointMotion.Locked;
		}
		set
		{
		}
	}

	public ConfigurableJointMotion angularXMotion
	{
		get
		{
			return ConfigurableJointMotion.Locked;
		}
		set
		{
		}
	}

	public ConfigurableJointMotion angularYMotion
	{
		get
		{
			return ConfigurableJointMotion.Locked;
		}
		set
		{
		}
	}

	public ConfigurableJointMotion angularZMotion
	{
		get
		{
			return ConfigurableJointMotion.Locked;
		}
		set
		{
		}
	}

	public SoftJointLimitSpring linearLimitSpring
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public SoftJointLimitSpring angularXLimitSpring
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public SoftJointLimitSpring angularYZLimitSpring
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public SoftJointLimit linearLimit
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public SoftJointLimit lowAngularXLimit
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public SoftJointLimit highAngularXLimit
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public SoftJointLimit angularYLimit
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public SoftJointLimit angularZLimit
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Vector3 targetPosition
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Vector3 targetVelocity
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public JointDrive xDrive
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public JointDrive yDrive
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public JointDrive zDrive
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Quaternion targetRotation
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Vector3 targetAngularVelocity
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public RotationDriveMode rotationDriveMode
	{
		get
		{
			return RotationDriveMode.XYAndZ;
		}
		set
		{
		}
	}

	public JointDrive angularXDrive
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public JointDrive angularYZDrive
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public JointDrive slerpDrive
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public JointProjectionMode projectionMode
	{
		get
		{
			return JointProjectionMode.None;
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

	public bool configuredInWorldSpace
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool swapBodies
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
	private void get_secondaryAxis_Injected(out Vector3 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_secondaryAxis_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void get_linearLimitSpring_Injected(out SoftJointLimitSpring ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_linearLimitSpring_Injected(ref SoftJointLimitSpring value)
	{
	}

	[SpecialName]
	private void get_angularXLimitSpring_Injected(out SoftJointLimitSpring ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_angularXLimitSpring_Injected(ref SoftJointLimitSpring value)
	{
	}

	[SpecialName]
	private void get_angularYZLimitSpring_Injected(out SoftJointLimitSpring ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_angularYZLimitSpring_Injected(ref SoftJointLimitSpring value)
	{
	}

	[SpecialName]
	private void get_linearLimit_Injected(out SoftJointLimit ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_linearLimit_Injected(ref SoftJointLimit value)
	{
	}

	[SpecialName]
	private void get_lowAngularXLimit_Injected(out SoftJointLimit ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_lowAngularXLimit_Injected(ref SoftJointLimit value)
	{
	}

	[SpecialName]
	private void get_highAngularXLimit_Injected(out SoftJointLimit ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_highAngularXLimit_Injected(ref SoftJointLimit value)
	{
	}

	[SpecialName]
	private void get_angularYLimit_Injected(out SoftJointLimit ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_angularYLimit_Injected(ref SoftJointLimit value)
	{
	}

	[SpecialName]
	private void get_angularZLimit_Injected(out SoftJointLimit ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_angularZLimit_Injected(ref SoftJointLimit value)
	{
	}

	[SpecialName]
	private void get_targetPosition_Injected(out Vector3 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_targetPosition_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void get_targetVelocity_Injected(out Vector3 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_targetVelocity_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void get_xDrive_Injected(out JointDrive ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_xDrive_Injected(ref JointDrive value)
	{
	}

	[SpecialName]
	private void get_yDrive_Injected(out JointDrive ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_yDrive_Injected(ref JointDrive value)
	{
	}

	[SpecialName]
	private void get_zDrive_Injected(out JointDrive ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_zDrive_Injected(ref JointDrive value)
	{
	}

	[SpecialName]
	private void get_targetRotation_Injected(out Quaternion ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_targetRotation_Injected(ref Quaternion value)
	{
	}

	[SpecialName]
	private void get_targetAngularVelocity_Injected(out Vector3 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_targetAngularVelocity_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void get_angularXDrive_Injected(out JointDrive ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_angularXDrive_Injected(ref JointDrive value)
	{
	}

	[SpecialName]
	private void get_angularYZDrive_Injected(out JointDrive ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_angularYZDrive_Injected(ref JointDrive value)
	{
	}

	[SpecialName]
	private void get_slerpDrive_Injected(out JointDrive ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_slerpDrive_Injected(ref JointDrive value)
	{
	}
}
