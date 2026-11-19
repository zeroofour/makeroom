using UnityEngine;

namespace Mirror.Examples.LagCompensationDemo;

public struct Snapshot3D : Snapshot
{
	public Vector3 position = default;

	public double remoteTime { get; set; } = 0.0;

	public double localTime { get; set; } = 0.0;

	public Snapshot3D(double remoteTime, double localTime, Vector3 position)
	{
	}

	public static Snapshot3D Interpolate(Snapshot3D from, Snapshot3D to, double t)
	{
		return default;
	}
}
