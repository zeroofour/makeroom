using System;
using UnityEngine;

namespace StinkySteak.NetcodeBenchmark;

[Serializable]
public struct WanderMoveWrapper : IMoveWrapper
{
	[SerializeField]
	private float _circleRadius;

	[SerializeField]
	private float _turnChance;

	[SerializeField]
	private float _maxRadius;

	[SerializeField]
	private float _mass;

	[SerializeField]
	private float _maxSpeed;

	[SerializeField]
	private float _maxForce;

	[SerializeField]
	private float _maxSpawnPositionRadius;

	private Vector3 _velocity;

	private Vector3 _wanderForce;

	private Vector3 _target;

	public static WanderMoveWrapper CreateDefault()
	{
		return default;
	}

	public void NetworkStart(Transform transform)
	{
	}

	public void NetworkUpdate(Transform transform)
	{
	}

	private Vector3 GetWanderForce(Transform transform)
	{
		return default;
	}

	private Vector3 GetRandomWanderForce()
	{
		return default;
	}
}
