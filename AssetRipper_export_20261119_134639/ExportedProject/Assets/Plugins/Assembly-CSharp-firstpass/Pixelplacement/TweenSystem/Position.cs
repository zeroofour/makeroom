using System;
using UnityEngine;

namespace Pixelplacement.TweenSystem
{
	internal class Position : TweenBase
	{
		private Transform _target;

		private Vector3 _start;

		public Vector3 EndValue { get; private set; }

		public Position(Transform target, Vector3 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
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
