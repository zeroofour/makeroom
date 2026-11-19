using UnityEngine;

namespace Mirror.Examples.Common.Controllers.Tank;

[RequireComponent(typeof(TankControllerHybrid))]
[RequireComponent(typeof(NetworkTransformHybrid))]
[AddComponentMenu("Network/Tank Turret (Hybrid)")]
public class TankTurretHybrid : TankTurretBase
{
	[Header("Network Transforms")]
	public NetworkTransformHybrid turretNetworkTransform;

	public NetworkTransformHybrid barrelNetworkTransform;

	protected override void Reset()
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
