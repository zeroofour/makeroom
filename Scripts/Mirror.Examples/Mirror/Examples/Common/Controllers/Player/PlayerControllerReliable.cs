using UnityEngine;

namespace Mirror.Examples.Common.Controllers.Player;

[RequireComponent(typeof(NetworkTransformReliable))]
[AddComponentMenu("Network/Player Controller (Reliable)")]
public class PlayerControllerReliable : PlayerControllerBase
{
	public override bool Weaved()
	{
		return false;
	}
}
