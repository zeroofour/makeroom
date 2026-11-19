using UnityEngine;

namespace Mirror.Examples.Pong;

public class Player : NetworkBehaviour
{
	public float speed;

	public Rigidbody2D rigidbody2d;

	private void FixedUpdate()
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
