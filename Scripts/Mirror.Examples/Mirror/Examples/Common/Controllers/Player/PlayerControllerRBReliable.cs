using UnityEngine;

namespace Mirror.Examples.Common.Controllers.Player;

[RequireComponent(typeof(NetworkTransformReliable))]
[AddComponentMenu("Network/Player Controller RB (Reliable)")]
public class PlayerControllerRBReliable : PlayerControllerRBBase
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
