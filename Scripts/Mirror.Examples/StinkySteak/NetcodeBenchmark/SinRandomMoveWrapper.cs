using System;
using UnityEngine;

namespace StinkySteak.NetcodeBenchmark;

[Serializable]
public struct SinRandomMoveWrapper : IMoveWrapper
{
	[SerializeField]
	private float _minSpeed;

	[SerializeField]
	private float _maxSpeed;

	[SerializeField]
	private float _amplitude;

	private Vector3 _targetPosition;

	private Vector3 _initialPosition;

	private float _speed;

	public static SinRandomMoveWrapper CreateDefault()
	{
		return default;
	}

	public void NetworkStart(Transform transform)
	{
	}

	public void NetworkUpdate(Transform transform)
	{
	}
}
