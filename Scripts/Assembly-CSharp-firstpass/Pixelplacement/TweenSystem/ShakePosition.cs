using System;
using UnityEngine;

namespace Pixelplacement.TweenSystem;

internal class ShakePosition : TweenBase
{
	private Transform _target;

	private Vector3 _initialPosition;

	private Vector3 _intensity;

	public Vector3 EndValue { get; private set; }

	public ShakePosition(Transform target, Vector3 initialPosition, Vector3 intensity, float duration, float delay, AnimationCurve curve, Action startCallback, Action completeCallback, Tween.LoopType loop, bool obeyTimescale)
	{
	}

	protected override bool SetStartValue()
	{
		return false;
	}

	protected override void Operation(float percentage)
	{
	}

	public override void Loop()
	{
	}

	public override void PingPong()
	{
	}
}
