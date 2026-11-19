using System;
using System.Collections.Generic;
using UnityEngine;

namespace Mirror.Examples.SnapshotInterpolationDemo;

public class ServerCube : MonoBehaviour
{
	[Header("Components")]
	public ClientCube client;

	[Header("Movement")]
	public float distance;

	public float speed;

	private Vector3 start;

	[Tooltip("Send N snapshots per second. Multiples of frame rate make sense.")]
	[Header("Snapshot Interpolation")]
	public int sendRate;

	private float lastSendTime;

	[Tooltip("Latency in seconds")]
	[Header("Latency Simulation")]
	public float latency;

	[Range(0f, 1f)]
	[Tooltip("Latency jitter, randomly added to latency.")]
	public float jitter;

	[Tooltip("Packet loss in %")]
	[Range(0f, 1f)]
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
}
