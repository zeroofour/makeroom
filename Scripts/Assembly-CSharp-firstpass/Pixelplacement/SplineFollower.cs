using System;
using UnityEngine;

namespace Pixelplacement;

[Serializable]
public class SplineFollower
{
	public Transform target;

	public float percentage;

	public bool faceDirection;

	private float _previousPercentage;

	private bool _previousFaceDirection;

	private bool _detached;

	public bool WasMoved => false;

	public void UpdateOrientation(Spline spline)
	{
	}
}
