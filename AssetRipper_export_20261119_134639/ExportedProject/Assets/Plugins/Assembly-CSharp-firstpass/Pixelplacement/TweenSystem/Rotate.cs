using System;
using UnityEngine;

namespace Pixelplacement.TweenSystem
{
	internal class Rotate : TweenBase
	{
		private Transform _target;

		private Vector3 _start;

		private Space _space;

		private Vector3 _previous;

		public Vector3 EndValue { get; private set; }

		public Rotate(Transform target, Vector3 endValue, Space space, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
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
