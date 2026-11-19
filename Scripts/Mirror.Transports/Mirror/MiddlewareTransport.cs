using System;
using UnityEngine;

namespace Mirror;

[DisallowMultipleComponent]
public abstract class MiddlewareTransport : Transport
{
	public Transport inner;

	public override bool Available()
	{
		return false;
	}

	public override int GetMaxPacketSize(int channelId = 0)
	{
		return 0;
	}

	public override int GetBatchThreshold(int channelId = 0)
	{
		return 0;
	}

	public override void Shutdown()
	{
	}

	public override void ClientConnect(string address)
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

	public override void ClientEarlyUpdate()
	{
	}

	public override void ClientLateUpdate()
	{
	}

	public override bool ServerActive()
	{
		return false;
	}

	public override void ServerStart()
	{
	}

	public override void ServerStop()
	{
	}

	public override void ServerSend(int connectionId, ArraySegment<byte> segment, int channelId)
	{
	}

	public override void ServerDisconnect(int connectionId)
	{
	}

	public override string ServerGetClientAddress(int connectionId)
	{
		return null;
	}

	public override Uri ServerUri()
	{
		return null;
	}

	public override void ServerEarlyUpdate()
	{
	}

	public override void ServerLateUpdate()
	{
	}
}
