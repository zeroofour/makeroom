using System;
using UnityEngine;

namespace Pixelplacement.TweenSystem
{
	internal class ValueVector2 : TweenBase
	{
		private Action<Vector2> _valueUpdatedCallback;

		private Vector2 _start;

		public Vector2 EndValue { get; private set; }

		public ValueVector2(Vector2 startValue, Vector2 endValue, Action<Vector2> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
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
