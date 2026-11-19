using UnityEngine;

namespace Mirror.Examples.Billiards;

public class RedBall : NetworkBehaviour
{
	[ServerCallback]
	private void OnTriggerEnter(Collider other)
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
