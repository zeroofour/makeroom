using UnityEngine;

namespace Mirror.Examples.Common.Controllers.Player;

[RequireComponent(typeof(NetworkTransformUnreliable))]
[AddComponentMenu("Network/Player Controller RB (Unreliable)")]
public class PlayerControllerRBUnreliable : PlayerControllerRBBase
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
