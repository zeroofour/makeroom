using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.AdditiveLevels;

public class FadeInOut : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFadeIn_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FadeInOut _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CFadeIn_003Ed__6(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CFadeOut_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FadeInOut _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CFadeOut_003Ed__8(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CFadeImage_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FadeInOut _003C_003E4__this;

		public float endAlpha;

		public float startAlpha;

		public float duration;

		private Color _003Ccolor_003E5__2;

		private float _003CelapsedTime_003E5__3;

		private float _003CfixedDeltaTime_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CFadeImage_003Ed__9(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	[Header("Components")]
	private Image panelImage;

	[Tooltip("Time in seconds to fade in")]
	[Range(1f, 10f)]
	[Header("Settings")]
	[SerializeField]
	private byte fadeInTime;

	[Tooltip("Time in seconds to fade out")]
	[Range(1f, 10f)]
	[SerializeField]
	private byte fadeOutTime;

	private bool isFading;

	private void OnValidate()
	{
	}

	public float GetFadeInTime()
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(_003CFadeIn_003Ed__6))]
	public IEnumerator FadeIn()
	{
		return null;
	}

	public float GetFadeOutTime()
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(_003CFadeOut_003Ed__8))]
	public IEnumerator FadeOut()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFadeImage_003Ed__9))]
	private IEnumerator FadeImage(float startAlpha, float endAlpha, float duration)
	{
		return null;
	}
}
