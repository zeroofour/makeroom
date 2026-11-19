using System;
using UnityEngine;

namespace Pixelplacement.TweenSystem
{
	internal class ShaderVector : TweenBase
	{
		private Material _target;

		private Vector4 _start;

		private string _propertyName;

		public Vector4 EndValue { get; private set; }

		public ShaderVector(Material target, string propertyName, Vector4 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
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
