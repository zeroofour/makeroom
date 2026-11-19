using UnityEngine;

namespace Mirror.Examples.Pong;

public class Ball : NetworkBehaviour
{
	public float speed;

	public Rigidbody2D rigidbody2d;

	public override void OnStartServer()
	{
	}

	private float HitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
	{
		return 0f;
	}

	[ServerCallback]
	private void OnCollisionEnter2D(Collision2D col)
	{
	}

	public override bool Weaved()
	{
		return false;
	}
}
