using System;
using UnityEngine;

namespace Pixelplacement.TweenSystem;

internal class AnchoredPosition : TweenBase
{
	private RectTransform _target;

	private Vector2 _start;

	public Vector2 EndValue { get; private set; }

	public AnchoredPosition(RectTransform target, Vector2 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
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
