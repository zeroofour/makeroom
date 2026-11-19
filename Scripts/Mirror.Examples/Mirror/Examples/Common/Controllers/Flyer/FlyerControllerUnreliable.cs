using UnityEngine;

namespace Mirror.Examples.Common.Controllers.Flyer;

[RequireComponent(typeof(NetworkTransformUnreliable))]
[AddComponentMenu("Network/Flyer Controller (Unreliable)")]
public class FlyerControllerUnreliable : FlyerControllerBase
{
	public override bool Weaved()
	{
		return false;
	}
}
