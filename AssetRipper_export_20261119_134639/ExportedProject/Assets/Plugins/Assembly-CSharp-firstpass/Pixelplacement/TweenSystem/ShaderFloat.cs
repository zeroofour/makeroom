using System;
using UnityEngine;

namespace Pixelplacement.TweenSystem
{
	internal class ShaderFloat : TweenBase
	{
		private Material _target;

		private float _start;

		private string _propertyName;

		public float EndValue { get; private set; }

		public ShaderFloat(Material target, string propertyName, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
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
