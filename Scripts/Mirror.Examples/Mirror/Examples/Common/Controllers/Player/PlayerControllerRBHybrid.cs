using UnityEngine;

namespace Mirror.Examples.Common.Controllers.Player;

[RequireComponent(typeof(NetworkTransformHybrid))]
[AddComponentMenu("Network/Player Controller RB (Hybrid)")]
public class PlayerControllerRBHybrid : PlayerControllerRBBase
{
	protected override void OnValidate()
	{
	}

	public override void Reset()
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
