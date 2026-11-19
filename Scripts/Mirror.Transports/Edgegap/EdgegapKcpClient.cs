using System;
using kcp2k;

namespace Edgegap;

public class EdgegapKcpClient : KcpClient
{
	private readonly byte[] relayReceiveBuffer;

	public uint userId;

	public uint sessionId;

	public ConnectionState connectionState;

	private double lastPingTime;

	public EdgegapKcpClient(Action OnConnected, Action<ArraySegment<byte>, KcpChannel> OnData, Action OnDisconnected, Action<ErrorCode, string> OnError, KcpConfig config)
		: base(null, null, null, null, null)
	{
	}

	public void Connect(string relayAddress, ushort relayPort, uint userId, uint sessionId)
	{
	}

	protected override bool RawReceive(out ArraySegment<byte> segment)
	{
		segment = default;
		return false;
	}

	protected override void RawSend(ArraySegment<byte> data)
	{
	}

	private void SendPing()
	{
	}

	public override void TickOutgoing()
	{
	}
}
