using UnityEngine;

namespace Mirror.Examples.BilliardsPredicted;

public struct PlayerInput(double timestamp, Vector3 force)
{
	public double timestamp = 0.0;

	public Vector3 force = default;
}
