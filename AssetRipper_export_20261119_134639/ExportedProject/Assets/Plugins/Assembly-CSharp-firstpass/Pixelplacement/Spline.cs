using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Pixelplacement
{
	[ExecuteInEditMode]
	public class Spline : MonoBehaviour
	{
		private class SplineReparam
		{
			public float length;

			public float percentage;

			public SplineReparam(float length, float percentage)
			{
			}
		}

		[CompilerGenerated]
		private Action m_OnSplineChanged;

		public Color color;

		[Range(0f, 1f)]
		public float toolScale;

		public TangentMode defaultTangentMode;

		public SplineDirection direction;

		public bool loop;

		public SplineFollower[] followers;

		private SplineAnchor[] _anchors;

		private int _curveCount;

		private int _previousAnchorCount;

		private int _previousChildCount;

		private bool _wasLooping;

		private bool _previousLoopChoice;

		private bool _anchorsChanged;

		private SplineDirection _previousDirection;

		private float _curvePercentage;

		private int _operatingCurve;

		private float _currentCurve;

		private int _previousLength;

		private int _slicesPerCurve;

		private List<SplineReparam> _splineReparams;

		private bool _lengthDirty;

		public float Length { get; private set; }

		public SplineAnchor[] Anchors => null;

		public Color SecondaryColor => default;

		public event Action OnSplineChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Reset()
		{
		}

		private void Update()
		{
		}

		private void HangleLengthChange()
		{
		}

		private float Reparam(float percent)
		{
			return 0f;
		}

		public void CalculateLength()
		{
		}

		public Vector3 Up(float percentage, bool normalized = true)
		{
			return default;
		}

		public Vector3 Right(float percentage, bool normalized = true)
		{
			return default;
		}

		public Vector3 Forward(float percentage, bool normalized = true)
		{
			return default;
		}

		public Vector3 GetDirection(float percentage, bool normalized = true)
		{
			return default;
		}

		public Vector3 GetPosition(float percentage, bool normalized = true)
		{
			return default;
		}

		public Vector3 GetPosition(float percentage, Vector3 relativeOffset, bool normalized = true)
		{
			return default;
		}

		public float ClosestPoint(Vector3 point, int divisions = 100)
		{
			return 0f;
		}

		public GameObject[] AddAnchors(int count)
		{
			return null;
		}

		public CurveDetail GetCurve(float percentage)
		{
			return default;
		}
	}
}
