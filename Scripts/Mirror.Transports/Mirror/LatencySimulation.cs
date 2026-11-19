using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Mirror;

[HelpURL("https://mirror-networking.gitbook.io/docs/transports/latency-simulaton-transport")]
[DisallowMultipleComponent]
public class LatencySimulation : Transport, PortTransport
{
	public Transport wrap;

	[Range(0f, 10000f)]
	[Tooltip("Latency in milliseconds (1000 = 1 second). Always applied to both reliable and unreliable, otherwise unreliable NetworkTime may be behind reliable [SyncVars/Commands/Rpcs] or vice versa!")]
	[Header("Common")]
	public float latency;

	[Range(0f, 1f)]
	[FormerlySerializedAs("latencySpikeMultiplier")]
	[Tooltip("Jitter latency via perlin(Time * jitterSpeed) * jitter")]
	public float jitter;

	[Tooltip("Jitter latency via perlin(Time * jitterSpeed) * jitter")]
	[FormerlySerializedAs("latencySpikeSpeedMultiplier")]
	public float jitterSpeed;

	[Header("Reliable Messages")]
	[Range(0f, 100f)]
	[Tooltip("Packet loss in %\n2% recommended for long term play testing, upto 5% for short bursts.\nAnything higher, or for a prolonged amount of time, suggests user has a connection fault.")]
	[Header("Unreliable Messages")]
	public float unreliableLoss;

	[Tooltip("Scramble % of unreliable messages, just like over the real network. Mirror unreliable is unordered.")]
	[Range(0f, 100f)]
	public float unreliableScramble;

	private readonly List<QueuedMessage> clientToServer;

	private readonly List<QueuedMessage> serverToClient;

	private readonly System.Random random;

	public ushort Port
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected virtual float Noise(float time)
	{
		return 0f;
	}

	private float SimulateLatency(int channeldId)
	{
		return 0f;
	}

	private void SimulateSend(int connectionId, ArraySegment<byte> segment, int channelId, float latency, List<QueuedMessage> messageQueue)
	{
	}

	public override bool Available()
	{
		return false;
	}

	public override void ClientConnect(string address)
	{
	}

	public override void ClientConnect(Uri uri)
	{
	}

	public override bool ClientConnected()
	{
		return false;
	}

	public override void ClientDisconnect()
	{
	}

	public override void ClientSend(ArraySegment<byte> segment, int channelId)
	{
	}

	public override Uri ServerUri()
	{
		return null;
	}

	public override bool ServerActive()
	{
		return false;
	}

	public override string ServerGetClientAddress(int connectionId)
	{
		return null;
	}

	public override void ServerDisconnect(int connectionId)
	{
	}

	public override void ServerSend(int connectionId, ArraySegment<byte> segment, int channelId)
	{
	}

	public override void ServerStart()
	{
	}

	public override void ServerStop()
	{
	}

	public override void ClientEarlyUpdate()
	{
	}

	public override void ServerEarlyUpdate()
	{
	}

	public override void ClientLateUpdate()
	{
	}

	public override void ServerLateUpdate()
	{
	}

	public override int GetBatchThreshold(int channelId)
	{
		return 0;
	}

	public override int GetMaxPacketSize(int channelId = 0)
	{
		return 0;
	}

	public override void Shutdown()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
