using UnityEngine;

namespace Mirror.Examples.Common.Controllers.Tank;

[AddComponentMenu("Network/Tank Turret (Unreliable)")]
[RequireComponent(typeof(TankControllerUnreliable))]
[RequireComponent(typeof(NetworkTransformUnreliable))]
public class TankTurretUnreliable : TankTurretBase
{
	[Header("Network Transforms")]
	public NetworkTransformUnreliable turretNetworkTransform;

	public NetworkTransformUnreliable barrelNetworkTransform;

	protected override void Reset()
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
