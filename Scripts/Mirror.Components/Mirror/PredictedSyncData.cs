using UnityEngine;

namespace Mirror;

public struct PredictedSyncData(float deltaTime, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity)
{
	public float deltaTime = 0f;

	public Vector3 position = default;

	public Quaternion rotation = default;

	public Vector3 velocity = default;

	public Vector3 angularVelocity = default;
}
