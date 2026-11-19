using UnityEngine;

namespace Mirror.Examples.LagCompensationDemo;

public struct Capture2D : Capture
{
	public Vector2 position = default;

	public Vector2 size = default;

	public double timestamp { get; set; } = 0.0;

	public Capture2D(double timestamp, Vector2 position, Vector2 size)
	{
	}

	public void DrawGizmo()
	{
	}

	public static Capture2D Interpolate(Capture2D from, Capture2D to, double t)
	{
		return default;
	}

	public override string ToString()
	{
		return null;
	}
}
