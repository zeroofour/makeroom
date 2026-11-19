using System;
using UnityEngine;

namespace StinkySteak.NetcodeBenchmark;

[Serializable]
public struct SinMoveYWrapper : IMoveWrapper
{
	[SerializeField]
	private float _minSpeed;

	[SerializeField]
	private float _maxSpeed;

	[SerializeField]
	private float _minAmplitude;

	[SerializeField]
	private float _maxAmplitude;

	[SerializeField]
	private float _positionMaxRandom;

	private Vector3 _initialPosition;

	private float _speed;

	private float _amplitude;

	public static SinMoveYWrapper CreateDefault()
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
