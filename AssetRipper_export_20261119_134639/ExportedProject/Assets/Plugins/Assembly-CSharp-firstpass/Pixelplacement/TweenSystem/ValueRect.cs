using System;
using UnityEngine;

namespace Pixelplacement.TweenSystem
{
	internal class ValueRect : TweenBase
	{
		private Action<Rect> _valueUpdatedCallback;

		private Rect _start;

		public Rect EndValue { get; private set; }

		public ValueRect(Rect startValue, Rect endValue, Action<Rect> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
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
}
