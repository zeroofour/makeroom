using System;
using UnityEngine;

namespace Pixelplacement.TweenSystem
{
	internal class TextMeshColor : TweenBase
	{
		private TextMesh _target;

		private Color _start;

		public Color EndValue { get; private set; }

		public TextMeshColor(TextMesh target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
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
