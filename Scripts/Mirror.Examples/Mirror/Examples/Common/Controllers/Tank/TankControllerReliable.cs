using UnityEngine;

namespace Mirror.Examples.Common.Controllers.Tank;

[RequireComponent(typeof(NetworkTransformReliable))]
[AddComponentMenu("Network/Tank Controller (Reliable)")]
public class TankControllerReliable : TankControllerBase
{
	public override bool Weaved()
	{
		return false;
	}
}
