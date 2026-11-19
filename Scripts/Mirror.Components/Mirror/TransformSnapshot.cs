using UnityEngine;

namespace Mirror;

public struct TransformSnapshot : Snapshot
{
	public Vector3 position = default;

	public Quaternion rotation = default;

	public Vector3 scale = default;

	public double remoteTime { get; set; } = 0.0;

	public double localTime { get; set; } = 0.0;

	public TransformSnapshot(double remoteTime, double localTime, Vector3 position, Quaternion rotation, Vector3 scale)
	{
	}

	public static TransformSnapshot Interpolate(TransformSnapshot from, TransformSnapshot to, double t)
	{
		return default;
	}

	public override string ToString()
	{
		return null;
	}
}
