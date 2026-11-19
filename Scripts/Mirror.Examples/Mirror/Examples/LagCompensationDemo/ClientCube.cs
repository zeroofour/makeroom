using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Mirror.Examples.LagCompensationDemo;

public class ClientCube : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CTemporarilyChangeColorToGreen_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ClientCube _003C_003E4__this;

		public Color color;

		private Renderer _003Cr_003E5__2;

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
		public _003CTemporarilyChangeColorToGreen_003Ed__21(int _003C_003E1__state)
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

	[Header("Components")]
	public ServerCube server;

	public Renderer render;

	[Header("Toggle")]
	public bool interpolate;

	[Header("Snapshot Interpolation")]
	public SnapshotInterpolationSettings snapshotSettings;

	public SortedList<double, Snapshot3D> snapshots;

	internal double localTimeline;

	private double localTimescale;

	private ExponentialMovingAverage driftEma;

	private ExponentialMovingAverage deliveryTimeEma;

	[Header("Debug")]
	public Color hitColor;

	public Color missedColor;

	public Color originalColor;

	[Header("Simulation")]
	private bool lowFpsMode;

	private double accumulatedDeltaTime;

	public double bufferTime => 0.0;

	private void Awake()
	{
	}

	public void OnMessage(Snapshot3D snap)
	{
	}

	private void Update()
	{
	}

	private void OnMouseDown()
	{
	}

	private void FlashColor(Color color)
	{
	}

	[IteratorStateMachine(typeof(_003CTemporarilyChangeColorToGreen_003Ed__21))]
	private IEnumerator TemporarilyChangeColorToGreen(Color color)
	{
		return null;
	}

	private void OnGUI()
	{
	}

	private void OnValidate()
	{
	}
}
