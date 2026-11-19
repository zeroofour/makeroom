using System;
using UnityEngine;

namespace Pixelplacement.TweenSystem;

public abstract class TweenBase
{
	public int targetInstanceID;

	public Tween.TweenType tweenType;

	protected float elapsedTime;

	public Tween.TweenStatus Status { get; private set; }

	public float Duration { get; private set; }

	public AnimationCurve Curve { get; private set; }

	public Keyframe[] CurveKeys { get; private set; }

	public bool ObeyTimescale { get; private set; }

	public Action StartCallback { get; private set; }

	public Action CompleteCallback { get; private set; }

	public float Delay { get; private set; }

	public Tween.LoopType LoopType { get; private set; }

	public float Percentage { get; private set; }

	public void Stop()
	{
	}

	public void Start()
	{
	}

	public void Resume()
	{
	}

	public void Rewind()
	{
	}

	public void Cancel()
	{
	}

	public void Finish()
	{
	}

	public void Tick()
	{
	}

	private void CleanUp()
	{
	}

	protected void ResetStartTime()
	{
	}

	protected void SetEssentials(Tween.TweenType tweenType, int targetInstanceID, float duration, float delay, bool obeyTimeScale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
	{
	}

	protected abstract bool SetStartValue();

	protected abstract void Operation(float percentage);

	public abstract void Loop();

	public abstract void PingPong();
}
