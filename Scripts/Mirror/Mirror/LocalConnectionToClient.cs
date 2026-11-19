using System;
using System.Collections.Generic;

namespace Mirror;

public class LocalConnectionToClient : NetworkConnectionToClient
{
	internal LocalConnectionToServer connectionToServer;

	internal readonly Queue<NetworkWriterPooled> queue;

	internal override void Send(ArraySegment<byte> segment, int channelId = 0)
	{
	}

	internal override bool IsAlive(float timeout)
	{
		return false;
	}

	protected override void UpdatePing()
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
}
