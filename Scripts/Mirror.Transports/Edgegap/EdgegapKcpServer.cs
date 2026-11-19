using System;
using System.Net;
using System.Net.Sockets;
using kcp2k;

namespace Edgegap;

public class EdgegapKcpServer : KcpServer
{
	private readonly byte[] relayReceiveBuffer;

	public uint userId;

	public uint sessionId;

	public ConnectionState state;

	protected Socket relaySocket;

	public EndPoint remoteEndPoint;

	private double lastPingTime;

	private bool relayActive;

	public EdgegapKcpServer(Action<int, IPEndPoint> OnConnected, Action<int, ArraySegment<byte>, KcpChannel> OnData, Action<int> OnDisconnected, Action<int, ErrorCode, string> OnError, KcpConfig config)
		: base(null, null, null, null, null)
	{
	}

	public override bool IsActive()
	{
		return false;
	}

	public void Start(string relayAddress, ushort relayPort, uint userId, uint sessionId)
	{
	}

	public override void Stop()
	{
	}

	protected override bool RawReceiveFrom(out ArraySegment<byte> segment, out int connectionId)
	{
		segment = default;
		connectionId = default;
		return false;
	}

	protected override void RawSend(int connectionId, ArraySegment<byte> data)
	{
	}

	private void SendPing()
	{
	}

	public override void TickOutgoing()
	{
	}
}
