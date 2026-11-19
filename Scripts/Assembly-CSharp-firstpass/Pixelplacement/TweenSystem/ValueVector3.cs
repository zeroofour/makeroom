using System;
using UnityEngine;

namespace Pixelplacement.TweenSystem;

internal class ValueVector3 : TweenBase
{
	private Action<Vector3> _valueUpdatedCallback;

	private Vector3 _start;

	public Vector3 EndValue { get; private set; }

	public ValueVector3(Vector3 startValue, Vector3 endValue, Action<Vector3> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
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
