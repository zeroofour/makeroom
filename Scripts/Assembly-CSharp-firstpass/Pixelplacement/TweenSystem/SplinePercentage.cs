using System;
using UnityEngine;

namespace Pixelplacement.TweenSystem;

internal class SplinePercentage : TweenBase
{
	private Transform _target;

	private Spline _spline;

	private float _startPercentage;

	private bool _faceDirection;

	public float EndValue { get; private set; }

	public SplinePercentage(Spline spline, Transform target, float startPercentage, float endPercentage, bool faceDirection, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
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
