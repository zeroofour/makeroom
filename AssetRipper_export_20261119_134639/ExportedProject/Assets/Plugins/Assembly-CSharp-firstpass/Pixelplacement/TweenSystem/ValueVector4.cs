using System;
using UnityEngine;

namespace Pixelplacement.TweenSystem
{
	internal class ValueVector4 : TweenBase
	{
		private Action<Vector4> _valueUpdatedCallback;

		private Vector4 _start;

		public Vector4 EndValue { get; private set; }

		public ValueVector4(Vector4 startValue, Vector4 endValue, Action<Vector4> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
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
