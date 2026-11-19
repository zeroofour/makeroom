using UnityEngine;

namespace Pixelplacement;

[ExecuteInEditMode]
[RequireComponent(typeof(LineRenderer))]
[RequireComponent(typeof(Spline))]
public class SplineRenderer : MonoBehaviour
{
	public int segmentsPerCurve;

	[Range(0f, 1f)]
	public float startPercentage;

	[Range(0f, 1f)]
	public float endPercentage;

	private LineRenderer _lineRenderer;

	private Spline _spline;

	private bool _initialized;

	private int _previousAnchorsLength;

	private int _previousSegmentsPerCurve;

	private int _vertexCount;

	private float _previousStart;

	private float _previousEnd;

	private void Reset()
	{
	}

	private void Update()
	{
	}

	private void UpdateLineRenderer()
	{
	}

	private void ConfigureLineRenderer()
	{
	}
}
