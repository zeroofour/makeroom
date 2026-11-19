using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Mirror;

public abstract class NetworkConnection
{
	public const int LocalConnectionId = 0;

	public bool isAuthenticated;

	public object authenticationData;

	public bool isReady;

	public float lastMessageTime;

	public readonly HashSet<NetworkIdentity> owned;

	protected Dictionary<int, Batcher> batches;

	public NetworkIdentity identity { get; internal set; }

	public double remoteTimeStamp { get; internal set; }

	internal NetworkConnection()
	{
	}

	protected Batcher GetBatchForChannelId(int channelId)
	{
		return null;
	}

	public void Send<T>(T message, int channelId = 0) where T : struct, NetworkMessage
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal virtual void Send(ArraySegment<byte> segment, int channelId = 0)
	{
	}

	protected abstract void SendToTransport(ArraySegment<byte> segment, int channelId = 0);

	internal virtual void Update()
	{
	}

	internal virtual bool IsAlive(float timeout)
	{
		return false;
	}

	public abstract void Disconnect();

	public virtual void Cleanup()
	{
	}
}
