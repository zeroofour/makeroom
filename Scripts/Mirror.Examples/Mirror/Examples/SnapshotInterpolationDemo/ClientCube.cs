using System.Collections.Generic;
using UnityEngine;

namespace Mirror.Examples.SnapshotInterpolationDemo;

public class ClientCube : MonoBehaviour
{
	[Header("Components")]
	public ServerCube server;

	public Renderer render;

	[Header("Toggle")]
	public bool interpolate;

	[Header("Snapshot Interpolation")]
	public SnapshotInterpolationSettings snapshotSettings;

	public SortedList<double, Snapshot3D> snapshots;

	private double localTimeline;

	private double localTimescale;

	private ExponentialMovingAverage driftEma;

	private ExponentialMovingAverage deliveryTimeEma;

	[Header("Debug")]
	public Color catchupColor;

	public Color slowdownColor;

	private Color defaultColor;

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

	private void OnGUI()
	{
	}

	private void OnValidate()
	{
	}
}
