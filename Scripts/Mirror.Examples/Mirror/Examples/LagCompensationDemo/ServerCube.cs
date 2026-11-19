using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Mirror.Examples.LagCompensationDemo;

public class ServerCube : MonoBehaviour
{
	[Header("Components")]
	public ClientCube client;

	[FormerlySerializedAs("collider")]
	public BoxCollider col;

	[Header("Movement")]
	public float distance;

	public float speed;

	private Vector3 start;

	[Header("Snapshot Interpolation")]
	[Tooltip("Send N snapshots per second. Multiples of frame rate make sense.")]
	public int sendRate;

	private float lastSendTime;

	[Header("Lag Compensation")]
	public LagCompensationSettings lagCompensationSettings;

	private double lastCaptureTime;

	private Queue<KeyValuePair<double, Capture2D>> history;

	public Color historyColor;

	[Header("Debug")]
	public double resultDuration;

	private double resultTime;

	private Capture2D resultBefore;

	private Capture2D resultAfter;

	private Capture2D resultInterpolated;

	[Header("Latency Simulation")]
	[Tooltip("Latency in seconds")]
	public float latency;

	[Range(0f, 1f)]
	[Tooltip("Latency jitter, randomly added to latency.")]
	public float jitter;

	[Range(0f, 1f)]
	[Tooltip("Packet loss in %")]
	public float loss;

	[Range(0f, 1f)]
	[Tooltip("Scramble % of unreliable messages, just like over the real network. Mirror unreliable is unordered.")]
	public float scramble;

	private System.Random random;

	private List<(double, Snapshot3D)> queue;

	public float sendInterval => 0f;

	private float SimulateLatency()
	{
		return 0f;
	}

	private float AverageLatency()
	{
		return 0f;
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Send(Vector3 position)
	{
	}

	private void Flush()
	{
	}

	private void Capture()
	{
	}

	public bool CmdClicked(Vector2 position)
	{
		return false;
	}

	private void OnDrawGizmos()
	{
	}
}
