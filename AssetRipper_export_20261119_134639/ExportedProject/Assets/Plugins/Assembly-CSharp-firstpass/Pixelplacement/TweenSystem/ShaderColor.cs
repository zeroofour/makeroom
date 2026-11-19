using System;
using UnityEngine;

namespace Pixelplacement.TweenSystem
{
	internal class ShaderColor : TweenBase
	{
		private Material _target;

		private Color _start;

		private string _propertyName;

		public Color EndValue { get; private set; }

		public ShaderColor(Material target, string propertyName, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
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
