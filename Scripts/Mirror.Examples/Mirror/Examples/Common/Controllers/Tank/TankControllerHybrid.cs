using UnityEngine;

namespace Mirror.Examples.Common.Controllers.Tank;

[RequireComponent(typeof(NetworkTransformHybrid))]
[AddComponentMenu("Network/Tank Controller (Hybrid)")]
public class TankControllerHybrid : TankControllerBase
{
	public override bool Weaved()
	{
		return false;
	}
}
