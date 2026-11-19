using UnityEngine;

namespace Mirror.Examples.Common.Controllers.Tank;

[AddComponentMenu("Network/Tank Turret (Reliable)")]
[RequireComponent(typeof(TankControllerReliable))]
[RequireComponent(typeof(NetworkTransformReliable))]
public class TankTurretReliable : TankTurretBase
{
	[Header("Network Transforms")]
	public NetworkTransformReliable turretNetworkTransform;

	public NetworkTransformReliable barrelNetworkTransform;

	protected override void Reset()
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
