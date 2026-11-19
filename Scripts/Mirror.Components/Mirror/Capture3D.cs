using UnityEngine;

namespace Mirror;

public struct Capture3D : Capture
{
	public Vector3 position = default;

	public Vector3 size = default;

	public double timestamp { get; set; } = 0.0;

	public Capture3D(double timestamp, Vector3 position, Vector3 size)
	{
	}

	public void DrawGizmo()
	{
	}

	public static Capture3D Interpolate(Capture3D from, Capture3D to, double t)
	{
		return default;
	}

	public override string ToString()
	{
		return null;
	}
}
