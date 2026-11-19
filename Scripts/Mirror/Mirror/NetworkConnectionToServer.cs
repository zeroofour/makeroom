using System;
using System.Runtime.CompilerServices;

namespace Mirror;

public class NetworkConnectionToServer : NetworkConnection
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected override void SendToTransport(ArraySegment<byte> segment, int channelId = 0)
	{
	}

	public override void Disconnect()
	{
	}
}
