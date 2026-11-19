using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Mirror;

public class NetworkConnectionToClient : NetworkConnection
{
	private readonly NetworkWriter reliableRpcs;

	private readonly NetworkWriter unreliableRpcs;

	public readonly int connectionId;

	public readonly HashSet<NetworkIdentity> observing;

	public Unbatcher unbatcher;

	private ExponentialMovingAverage driftEma;

	private ExponentialMovingAverage deliveryTimeEma;

	public double remoteTimeline;

	public double remoteTimescale;

	private double bufferTimeMultiplier;

	private readonly SortedList<double, TimeSnapshot> snapshots;

	public int snapshotBufferSizeLimit;

	private double lastPingTime;

	internal ExponentialMovingAverage _rtt;

	public virtual string address { get; private set; }

	private double bufferTime => 0.0;

	public double rtt => 0.0;

	internal NetworkConnectionToClient()
	{
	}

	public NetworkConnectionToClient(int networkConnectionId, string clientAddress = "localhost")
	{
	}

	public override string ToString()
	{
		return null;
	}

	public void OnTimeSnapshot(TimeSnapshot snapshot)
	{
	}

	public void UpdateTimeInterpolation()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected override void SendToTransport(ArraySegment<byte> segment, int channelId = 0)
	{
	}

	protected virtual void UpdatePing()
	{
	}

	internal override void Update()
	{
	}

	public override void Disconnect()
	{
	}

	internal void AddToObserving(NetworkIdentity netIdentity)
	{
	}

	internal void RemoveFromObserving(NetworkIdentity netIdentity, bool isDestroyed)
	{
	}

	internal void RemoveFromObservingsObservers()
	{
	}

	internal void AddOwnedObject(NetworkIdentity obj)
	{
	}

	internal void RemoveOwnedObject(NetworkIdentity obj)
	{
	}

	internal void DestroyOwnedObjects()
	{
	}
}
