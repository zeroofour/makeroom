using System;
using UnityEngine;

namespace Pixelplacement.TweenSystem
{
	internal class ShaderInt : TweenBase
	{
		private Material _target;

		private int _start;

		private string _propertyName;

		public int EndValue { get; private set; }

		public ShaderInt(Material target, string propertyName, int endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
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
