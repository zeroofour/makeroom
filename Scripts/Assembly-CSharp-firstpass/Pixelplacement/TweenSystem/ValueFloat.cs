using System;
using UnityEngine;

namespace Pixelplacement.TweenSystem;

internal class ValueFloat : TweenBase
{
	private Action<float> _valueUpdatedCallback;

	private float _start;

	public float EndValue { get; private set; }

	public ValueFloat(float startValue, float endValue, Action<float> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
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
