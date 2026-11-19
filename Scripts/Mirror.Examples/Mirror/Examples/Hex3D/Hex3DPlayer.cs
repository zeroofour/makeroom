using UnityEngine;

namespace Mirror.Examples.Hex3D;

[AddComponentMenu(null)]
public class Hex3DPlayer : NetworkBehaviour
{
	[Range(1f, 20f)]
	public float speed;

	private void Update()
	{
	}

	private void OnGUI()
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
