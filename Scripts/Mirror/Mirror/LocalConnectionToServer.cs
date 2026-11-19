using System;
using System.Collections.Generic;

namespace Mirror;

public class LocalConnectionToServer : NetworkConnectionToServer
{
	internal LocalConnectionToClient connectionToClient;

	internal readonly Queue<NetworkWriterPooled> queue;

	private bool connectedEventPending;

	private bool disconnectedEventPending;

	internal void QueueConnectedEvent()
	{
	}

	internal void QueueDisconnectedEvent()
	{
	}

	internal override void Send(ArraySegment<byte> segment, int channelId = 0)
	{
	}

	internal override void Update()
	{
	}

	internal void DisconnectInternal()
	{
	}

	public override void Disconnect()
	{
	}

	internal override bool IsAlive(float timeout)
	{
		return false;
	}
}
